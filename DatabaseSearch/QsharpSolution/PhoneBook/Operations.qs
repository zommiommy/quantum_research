namespace Quantum.PhoneBook
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    
    operation Set(desired: Result, q1: Qubit): Unit {  
        let current = M(q1);  
        if (desired != current) {  
            X(q1);  
        }   
    }

	operation SHIFT(q : Qubit[]) : Unit {
		body(...) {
			X(q[0]);
		}
		controlled auto;
	}

	operation CSHIFT(q : Qubit[]) : Unit {
		(Controlled SHIFT)([q[0]], [q[1], q[2]]);
	}

	operation ICNOT(q : Qubit[]) : Unit {
		body(...) {
			X(q[0]);	// assuming control qubit is |0>, flip it
			(Controlled X)([q[0]], q[1]);
			X(q[0]);	// restore original state of control qubit
		}
		controlled auto;
	}

	// inverse control on gates that get 1 qubit
	operation IC_1q(controls : Qubit[], gate : (Qubit=>Unit is Ctl), gate_qubit : Qubit) : Unit {
		ApplyToEach(X, controls);	// assuming control qubit is |0>, flip it
		(Controlled gate)(controls, gate_qubit);
		ApplyToEach(X, controls);	// restore original state of control qubit
	}
	
	// inverse control on gates that get multiple qubits
	operation IC_mq(controls : Qubit[], gate : (Qubit[]=>Unit is Ctl), gate_qubits : Qubit[]) : Unit {
		ApplyToEach(X, controls);	// assuming control qubit is |0>, flip it
		(Controlled gate)(controls, gate_qubits);
		ApplyToEach(X, controls);	// restore original state of control qubit
	}
    
    operation GateTest (q1 : Result, q2 : Result) : (Result,Result) {

		using(q = Qubit[3]) {
			Set(Zero, q[0]);
			Set(q1, q[1]);
			Set(q2, q[2]);

			IC_1q([q[1]], X, q[2]);

			let res1 = M(q[1]);
			let res2 = M(q[2]);

			ResetAll(q);
			return (res1,res2);

		}
    }

	operation PhoneBookSearch (q0 : Result, q1 : Result, q2 : Result) : (Result,Result,Result) {
	
		let n1 = 1;		// number of qubits for the name
		let n2 = 2;		// number of qubits for the telephone number

		using (q = Qubit[n1+n2]) {

			Set(q0, q[0]);
			Set(q1, q[1]);
			Set(q2, q[2]);
		
			// building the primed matrix

			IC_1q([q[0],q[1]], H, q[2]);

			// exchange rows 1 and 3
			
			SHIFT([q[0], q[1]]);	// SHIFT3
			(Controlled SWAP)([q[0]], (q[1], q[2]));
			(Controlled ICNOT)([q[0]], [q[1], q[2]]);
			(Controlled SWAP)([q[0]], (q[1], q[2]));
			SHIFT([q[0], q[1]]);	// SHIFT3

			// returning measurements

			let res0 = M(q[0]);
			let res1 = M(q[1]);
			let res2 = M(q[2]);
			ResetAll(q);
			return (res0, res1, res2);
		}
	}
}
