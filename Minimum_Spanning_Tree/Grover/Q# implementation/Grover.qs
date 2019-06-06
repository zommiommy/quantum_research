namespace Grover
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
	open Microsoft.Quantum.Convert;

    operation HelloQ () : Unit {
        Message("Hello quantum world!");
    }

	operation PrepareBitString(bitstring : Bool[], register : Qubit[]) : Unit 
	is Adj + Ctl {

		let nQubits = Length(register);
		for (idxQubit in 0..nQubits - 1) {
		  if (bitstring[idxQubit]) {
		     X(register[idxQubit]);
			}
		}
	}

	operation RegisterSetup(register : Qubit[]) : Unit {
		PrepareBitString([false, false, false, false, true], register); // |00..001>
		
		for (q in register) {
			H(q);
		}
	}

	operation BooleanOracle (markedElement : Int, register : Qubit[]) : Unit {
		let databaseSize = Length(register)-1;
		let boolMarked = IntAsBoolArray(markedElement, databaseSize);

		for(i in 0 .. databaseSize-1) {
			if(boolMarked[i] == false) {
				X(register[databaseSize-i-1]);
			}
		}
		
		let controls = register[0 .. Length(register)-2];
		let target = register[Length(register)-1];

		Controlled X(controls, target);

		for(i in 0 .. databaseSize-1) {
			if(boolMarked[i] == false) {
				X(register[databaseSize-i-1]);
			}
		}
	}

	operation Grover (registerComplete : Qubit[]) : Unit {
		let register = registerComplete[0 .. Length(registerComplete)-2];

		for(q in register) {
			H(q);
			X(q);
		}

		let controls = register[0 .. Length(register)-2];
		let target = register[Length(register)-1];

		Controlled Z(controls, target);

		for(q in register) {
			X(q);
			H(q);
		}
	}

	operation ApplyGroverSearch (markedElement : Int, nIterations : Int, nDatabaseQubits : Int) : Result {
		mutable resultSuccess = Zero;
        
		using (qubits = Qubit[nDatabaseQubits+1]){
			RegisterSetup(qubits);

			for(i in 1 .. nIterations) {
				BooleanOracle(markedElement, qubits);
				Grover(qubits);
			}

			for(i in 0 .. nDatabaseQubits-1) {
				if (M(qubits[i]) == One) {
				    Message("1");
				}
				else {
					Message("0");
				}
			}

			ResetAll(qubits);
		}
		
		return (resultSuccess);
	}
}
