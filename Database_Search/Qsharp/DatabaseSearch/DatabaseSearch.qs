// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
namespace Quantum.DatabaseSearch {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Canon;
    
    
    //////////////////////////////////////////////////////////////////////////
    // Introduction //////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////
    
    // This sample will walk through several examples of searching a database
    // of N elements for a particular marked item using just O(1/√N) queries
    // to the database. In particular, we will follow Grover's algorithm, as
    // described in the standard library guide.
    
    // We will model the database by an oracle D that acts to map indices
    // to a flag indicating whether a given index is marked. In particular,
    // let |z〉 be a single-qubit computational basis state (that is, either
    // |0〉 or |1〉, and let |k〉 be a state representing an index k ∈ {0, 1,
    // …, N }. Then
    
    //     D |z〉 |k〉 = |z ⊕ xₖ〉 |k〉,
    
    // where x = x₀ x₁ … x_{N - 1} is a binary string such that xₖ is 1
    // if and only if the kth item is marked, and where ⊕ is the classical
    // exclusive OR gate. Note that given this definition, we know how D
    // transforms arbitrary states by linearity -- given an input state
    // that is a linear combination of orthogonal states |z〉|k〉 summed over the
    // z and k indices, D acts on each state independently.
    
    // First, we work out an example of how to construct and apply D without
    // using the canon. We then implement all the steps of Grover search
    // manually using this database oracle. Second, we show the amplitude
    // amplification libraries provided with the canon can make this task
    // significantly easier.
    
    //////////////////////////////////////////////////////////////////////////
    // Database Search with Manual Oracle Definitions ////////////////////////
    //////////////////////////////////////////////////////////////////////////
    
    /// # Summary
    /// Given a qubit to use to store a mark bit and a register corresponding
    /// to a database, marks the first qubit conditioned on the register
    /// state being the all-ones state |11…1〉.
    ///
    /// # Input
    /// ## markedQubit
    /// A qubit to be targeted by an `X` operation controlled on whether
    /// the state of `databaseRegister` corresponds to a marked item.
    /// ## databaseRegister
    /// A register representing the target of a query to the database.
    ///
    /// # Remarks
    /// Implements the operation
    ///
    ///     |z〉 |k〉 ↦ |z ⊕ f(k)〉 |k〉,
    ///
    /// where f(k) = 1 if and only if k = 2^(Length(databaseRegister)) - 1 and
    /// 0 otherwise.
    operation DatabaseOracle (markedQubit : Qubit, databaseRegister : Qubit[]) : Unit {
        
        body (...) {
            // The Controlled functor applies its operation conditioned on the
            // first input being in the |11…1〉 state, which is precisely
            // what we need for this example.
            Controlled X(databaseRegister, markedQubit);
        }
        
        adjoint invert;
    }
    
    
    // Grover's algorithm for quantum database searching requires that we
    // prepare the state given by the uniform superposition over all
    // computational basis states,
    
    //     |u〉 = Σₖ |k〉 = H^{⊗ n} |00…0〉,
    
    /// # Summary
    /// Given a register of qubits initially in the state |00…0〉, prepares
    /// a uniform superposition over all computational basis states.
    ///
    /// # Input
    /// ## databaseRegister
    /// A register of n qubits initially in the |00…0〉 state.
    operation UniformSuperposition (databaseRegister : Qubit[]) : Unit {
        
        body (...) {
            let nQubits = Length(databaseRegister);
            
            for (idxQubit in 0 .. nQubits - 1) {
                H(databaseRegister[idxQubit]);
            }
        }
        
        adjoint invert;
    }
    
    
    // We will define the state preparation oracle as a black-box unitary that
    // creates a uniform superposition using `UniformSuperposition` U, 
	// then marks the target state using the `DatabaseOracle` D.
	// When acting on the input state |00…0〉, this prepares the start state
    
    /// # Summary
    /// Given a register of qubits initially in the state |00…0〉, prepares
    /// the start state |1〉|N-1〉/√N + |0〉(|0〉+|1〉+...+|N-2〉)/√N.
    ///
    /// # Input
    /// ## markedQubit
    /// Qubit that indicates whether database element is marked.
    /// ## databaseRegister
    /// A register of n qubits initially in the |00…0〉 state.
    operation StatePreparation(markedQubit : Qubit, databaseRegister : Qubit[]) : Unit {
        
        body (...) {
            UniformSuperposition(databaseRegister);
            DatabaseOracle(markedQubit, databaseRegister);
        }
        
        adjoint invert;
    }
    
    
    // Grover's algorithm requires reflections about the marked state and the
    // start state. A reflection R is a unitary operator with eigenvalues ± 1,
    // and reflection about an arbitrary state |ψ〉 may be defined as
    
    // R = 1 - 2 |ψ〉〈ψ|.
    
    // Thus R|ψ〉 = -|ψ〉 applies a -1 phase, and R(|ψ〉) on any other state applies a
    // +1 phase. We now implement these reflections.
    
    /// # Summary
    /// Reflection `RM` about the marked state.
    ///
    /// # Input
    /// ## markedQubit
    /// Qubit that indicated whether database element is marked.
    operation ReflectMarked (markedQubit : Qubit) : Unit {
        
        // Marked elements always have the marked qubit in the state |1〉.
        R1(PI(), markedQubit);

		// R1 ? PI() ?
    }
    

	operation XAll (databaseRegister : Qubit[]) : Unit {
		
		let nQubits = Length(databaseRegister);

		for (idxQubit in 0 .. nQubits - 1) {
            X(databaseRegister[idxQubit]);
        }
	}
    
    /// # Summary
    /// Reflection about the |00…0〉 state.
    ///
    /// # Input
    /// ## databaseRegister
    /// A register of 1+n qubits initially in the |00…0〉 state.
    operation ReflectZero (databaseRegister : Qubit[]) : Unit {
        
        let nQubits = Length(databaseRegister);
        
        XAll(databaseRegister);
        
        Controlled Z(databaseRegister[1 .. nQubits-1], databaseRegister[0]);
        
        XAll(databaseRegister);
    }
    
    
    /// # Summary
    /// Reflection `RS` about the start state DU|0〉|0〉.
    ///
    /// # Input
    /// ## markedQubit
    /// Qubit that indicated whether database element is marked.
    /// ## databaseRegister
    /// A register of n qubits initially in the |00…0〉 state.
    operation ReflectStart (markedQubit : Qubit, databaseRegister : Qubit[]) : Unit {
        
        Adjoint StatePreparation(markedQubit, databaseRegister);
        ReflectZero([markedQubit] + databaseRegister);
        StatePreparation(markedQubit, databaseRegister);
    }
    
    
    // We may then search our database for the marked elements by performing
    // on the start state a sequence of alternating reflections about the
    // marked state and the start state. The product RS · RM is known as the
    // Grover iterator, and each application of it rotates |s〉 in the two-
    // dimensional subspace by angle 2θ. Thus M application of it creates the
    // state
    
    // (RS · RM)^M |s〉 = sin((2M+1)θ) |1〉|N-1〉 + cos((2M+1)θ) |0〉(|0〉+|1〉+...+|N-2〉)
    
    // Observe that if we choose M = O(1/√N), we can obtain an O(1)
    // probability of obtaining the marked state |1〉. This is the Quantum speedup!
    
    /// # Summary
    /// Prepares the start state and boosts the amplitude of the marked
    /// subspace by a sequence of reflections about the marked state and the
    /// start state.
    ///
    /// # Input
    /// ## nIterations
    /// Number of applications of the Grover iterate (RS · RM).
    /// ## markedQubit
    /// Qubit that indicated whether database element is marked.
    /// ## databaseRegister
    /// A register of n qubits initially in the |00…0〉 state.
    operation QuantumSearch (nIterations : Int, markedQubit : Qubit, databaseRegister : Qubit[]) : Unit {
        
        StatePreparation(markedQubit, databaseRegister);
        
        // Loop over Grover iterates.
        for (idx in 0 .. nIterations-1) {
            ReflectMarked(markedQubit);
            ReflectStart(markedQubit, databaseRegister);
        }
    }
    
    
    // Let us now create an operation that allocates qubits for Grover's
    // algorithm, implements the `QuantumSearch`, measures the marked qubit
    // the database register, and returns the measurement results.
    
    /// # Summary
    /// Performs quantum search for the marked element and returns an index
    /// to the found element in binary format. Finds the marked element with
    /// probability sin²((2*nIterations+1) sin⁻¹(1/√N)).
    ///
    /// # Input
    /// ## nIterations
    /// Number of applications of the Grover iterate (RS · RM).
    /// ## nDatabaseQubits
    /// Number of qubits in the database register.
    ///
    /// # Output
    /// Measurement outcome of marked Qubit and measurement outcomes of
    /// the database register.
    operation ApplyQuantumSearch (nIterations : Int, nDatabaseQubits : Int) : (Result, Result[]) {
        
        // Allocate variables to store measurement results.
        mutable resultSuccess = Zero;
        mutable resultElement = new Result[nDatabaseQubits];
        
        // Allocate nDatabaseQubits+1 qubits. These are all in the |0〉 state.
        using (qubits = Qubit[nDatabaseQubits+1]) {
            
            // Define marked qubit to be indexed by 0.
            let markedQubit = qubits[0];
            
            // Let all other qubits be the database register.
            let databaseRegister = qubits[1 .. nDatabaseQubits];
            
            // Implement the quantum search algorithm.
            QuantumSearch(nIterations, markedQubit, databaseRegister);
            
            // Measure the marked qubit. On success, this should be One.
            set resultSuccess = M(markedQubit);
            
            // Measure the state of the database register post-selected on
            // the state of the marked qubit.
            set resultElement = MultiM(databaseRegister);
            
            // These reset all qubits to the |0〉 state, which is required
            // before deallocation.
            if (resultSuccess == One) {
                X(markedQubit);
            }
            
            for (idxResult in 0 .. nDatabaseQubits-1) {
                
                if (resultElement[idxResult] == One) {
                    X(databaseRegister[idxResult]);
                }
            }
        }
        
        // Returns the measurement results of the algorithm.
        return (resultSuccess, resultElement);
    }
    
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
    operation ApplyGroverSearch (markedElements : Int[], nIterations : Int, nDatabaseQubits : Int) : (Result, Int) {
        
        // Allocate variables to store measurement results.
        mutable resultSuccess = Zero;
        mutable numberElement = 0;
        
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

