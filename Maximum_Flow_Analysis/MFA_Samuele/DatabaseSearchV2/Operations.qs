namespace Quantum.DatabaseSearch {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Canon;
    
    
    //////////////////////////////////////////////////////////////////////////
    // Database Search with the Canon ////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////
    
    // Our second example makes full use of the amplitude amplification
    // library and other supporting libraries to implement Grover's algorithm
    // more easily. We also consider a more general instance of the database
    // oracle that allows us to mark multiple elements.
    
    // The amplitude amplification library has a function called
    // `AmpAmpByOracle` that automates many details of Grover search.
    
    // The state oracle is precisely the `StatePreparationOracle` operation we
    // defined above with one major difference -- Its arguments have signature
    // the signature (Int, Qubit[]). Rather than directly passing the marked
    // qubit to the operation, we instead pass an integer than indexes The
    // location of the marked qubit in the qubit array, which now encompasses
    // all qubits.
    
    // Our goal is thus to construct this `StateOracle` oracle type and pass it
    // to the `AmpAmpByOracle` function, that automatically prepares a quantum state where the
    // marked subspace has been amplified.
    
    /// # Summary
    /// Database oracle `D` constructed from classical database.
    ///
    /// # Input
    /// ## markedElements
    /// Indices to marked elements in database.
    /// ## markedQubit
    /// Qubit that indicated whether database element is marked.
    /// ## databaseRegister
    /// A register of n qubits initially in the |00…0〉 state.
    ///
    /// # Remarks
    /// This implements the oracle D |z〉 |k〉 = |z ⊕ xₖ〉 |k〉 used in the Grover
    /// search algorithm. xₖ is 1 if k is in "markedElements" and 0 otherwise.
    operation DatabaseOracleFromInts (markedElements : Int[], markedQubit : Qubit, databaseRegister : Qubit[]) : Unit {
        
        body (...) {
            let nMarked = Length(markedElements);
            
            for (idxMarked in 0 .. nMarked-1) {
                
                // Note: As X accepts a Qubit, and ControlledOnInt only
                // accepts Qubit[], we use ApplyToEachCA(X, _) which accepts
                // Qubit[] even though the target is only 1 Qubit.
                (ControlledOnInt(markedElements[idxMarked], ApplyToEachCA(X, _)))(databaseRegister, [markedQubit]);
            }
        }
        
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }
    
    
    // The `StateOracle` described above is now constructed from partial
    // application of `GroverStatePrepOracle`. Note that we now index the
    // marked qubit with an integer.
    
    /// # Summary
    /// Preparation of start state from database oracle and oracle `U` that
    /// creates a uniform superposition over database indices.
    ///
    /// # Input
    /// ## markedElements
    /// Indices to marked elements in database.
    /// ## idxMarkedQubit
    /// Index to `MarkedQubit`.
    /// ## startQubits
    /// The collection of the n+1 qubits `MarkedQubit` and `databaseRegister`
    /// initially in the |00…0〉 state.
    ///
    /// # Remarks
    /// This implements an oracle `DU` that prepares the start state
    /// DU|0〉|0〉 = √(M/N)|1〉|marked〉 + √(1-(M/N)^2)|0〉|unmarked〉 where
    /// `M` is the length of `markedElements`, and
    /// `N` is 2^n, where `n` is the number of database qubits.
    operation GroverStatePrepOracleImpl (markedElements : Int[], idxMarkedQubit : Int, startQubits : Qubit[]) : Unit {
        
        body (...) {
            let flagQubit = startQubits[idxMarkedQubit];
            let databaseRegister = Exclude([idxMarkedQubit], startQubits);
            
            // Apply oracle `U`
            ApplyToEachCA(H, databaseRegister);
            
            // Apply oracle `D`
            DatabaseOracleFromInts(markedElements, flagQubit, databaseRegister);
        }
        
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }
    
    
    /// # Summary
    /// `StateOracle` type for the preparation of a start state that has a
    /// marked qubit entangled with some desired state in the database
    /// register.
    ///
    /// # Input
    /// ## markedElements
    /// Indices to marked elements in database.
    ///
    /// # Output
    /// A `StateOracle` type with signature
    /// ((Int, Qubit[]) => (): Adjoint, Controlled).
    function GroverStatePrepOracle (markedElements : Int[]) : StateOracle {
        
        return StateOracle(GroverStatePrepOracleImpl(markedElements, _, _));
    }
    
    
    // The library function `AmpAmpByOracle` then returns a unitary that
    // implements all steps of Grover's algorithm.
    
    /// # Summary
    /// Grover's search algorithm using library functions.
    ///
    /// # Input
    /// ## markedElements
    /// Indices to marked elements in database.
    /// ## nIterations
    /// Number of iterations of the Grover iteration to apply.
    /// ## idxMarkedQubit
    /// Index to `MarkedQubit`.
    ///
    /// # Output
    /// Unitary implementing Grover's search algorithm.
    ///
    /// # Remarks
    /// On input |0〉|0〉, this prepares the state |1〉|marked〉 with amplitude
    /// Sin((2*nIterations + 1) ArcSin(Sqrt(M/N))).
    function GroverSearch (markedElements : Int[], nIterations : Int, idxMarkedQubit : Int) : (Qubit[] => Unit : Adjoint, Controlled) {
        
        return AmpAmpByOracle(nIterations, GroverStatePrepOracle(markedElements), idxMarkedQubit);
    }
    
    
    // Let us now allocate qubits and run GroverSearch.
    
    /// # Summary
    /// Performs quantum search for the marked elements and returns an index
    /// to the found element in integer format.
    ///
    /// # Input
    /// ## markedElements
    /// Indices to marked elements in database.
    /// ## nIterations
    /// Number of applications of the Grover iterate (RS · RM).
    /// ## nDatabaseQubits
    /// Number of qubits in the database register.
    ///
    /// # Output
    /// Measurement outcome of marked Qubit and measurement outcomes of
    /// the database register converted to an integer.
    operation ApplyGroverSearch (
		list : Int[],
		elementsQubits : Int, 
		listIndexingQubits : Int, 
		targetElement : Int, 
		nIterations : Int) : (Result, Int) {
        
        // Allocate variables to store measurement results.
        mutable resultSuccess = Zero;
        mutable numberElement = 0;

		let nDatabaseQubits = listIndexingQubits + elementsQubits;

		let markedElements = (1, 2); // creare gli elementi fatti da [idx|elem]
        
        // Allocate nDatabaseQubits + 1 qubits. These are all in the |0〉
        // state.
        using (qubits = Qubit[nDatabaseQubits + 1]) {
            
            // Define marked qubit to be indexed by 0.
            let markedQubit = qubits[0];
            
            // Let all other qubits be the database register.
            let databaseRegister = qubits[1 .. nDatabaseQubits];
            
            // Implement the quantum search algorithm.
            (GroverSearch(markedElements, nIterations, 0))(qubits);
            
            // Measure the marked qubit. On success, this should be One.
            set resultSuccess = M(markedQubit);
            
            // Measure the state of the database register post-selected on
            // the state of the marked qubit.
            let resultElement = MultiM(databaseRegister);
            set numberElement = PositiveIntFromResultArr(resultElement);
            
            // These reset all qubits to the |0〉 state, which is required
            // before deallocation.
            ResetAll(qubits);
        }
        
        // Returns the measurement results of the algorithm.
        return (resultSuccess, numberElement);
    }
    
}

