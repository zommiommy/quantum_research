import cirq
from math import floor, pi, sqrt
from cirq import cirq.circuits.circuit.Circuit as Circuit

length = 10
number_of_expected_results = 5
qubits = [cirq.GridQubit(i, 0) for i in range(length)]
class Grover():

def __init__(self, qubits : List) -> None:
    self.qubits = qubits
    self.diffusion = _construct_diffusion()
    

def make_diffusion(self) -> Circuit:
    
    circuit = cirq.Circuit()
    circuit.append(cirq.H(q) for q in self.qubits)
    circuit.append(cirq.X(q) for q in self.qubits)
    controllee= []
    for i in range(length - 1):
        controllee.append(self.qubits[i])
    
    controlled = cirq.control(cirq.Z, controllee)(qubits[-1])    

    circuit.append(controlled)

    circuit.append(cirq.X(q) for q in self.qubits)
    circuit.append(cirq.H(q) for q in self.qubits)
               
    print(circuit)
    
    
def make_oracle(circuit : Circuit, self) -> Circuit
    return circuit.append(Cirq.Z(q) q in self.qubits)
                           

def run(self, circuit : Circuit, oracle : Circuit, number_of_expected_results : int = 1) -> Circuit:
        number_of_iterations = floor((pi / 4)*sqrt((2**len(self.qubits)) / number_of_expected_results))

        for _ in range(number_of_iterations):
            

        return circuit