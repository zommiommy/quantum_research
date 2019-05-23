namespace Quantum.QSharpApplication2
{

    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;

	operation DSWAP(q : Qubit[]) : Unit {
		// q : Qubit[2]
		I(q[0]);
		X(q[1]);
	}

	operation SHIFT(q : Qubit[]) : Unit {
		// q : Qubit[2]
		X(q[0]);
		I(q[1]);
	}

	operation ICNOT(q : Qubit[]) : Unit {
		// q : Qubit[2]
		//DSWAP(q);
		SHIFT(q);
		CNOT(q[0],q[1]);
	}
    
    operation HelloQ () : (Result,Result) {
        

		using(q = Qubit[2]) {

			Message("0,1");
			
			//X(q[0]);
			X(q[1]);
			ICNOT(q);

			let res1 = M(q[0]);
			let res2 = M(q[1]);

			
			Reset(q[1]);
			Reset(q[0]);
			
			return (res1,res2);

		}
    }
}
