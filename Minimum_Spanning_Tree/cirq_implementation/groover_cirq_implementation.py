import cirq
from math import floor, pi, sqrt
length = 8
number_of_expected_results = 1
qubits = [cirq.GridQubit(i, 0) for i in range(length)]

class Grover():
    def __init__(self, qubits):
        self.qubits = qubits
        self.diffusion = self.make_diffusion()
    

    def make_diffusion(self):

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
        return circuit
        

    def run(self, circuit, oracle, number_of_expected_results : int = 1):
            number_of_iterations = floor((pi / 4)*sqrt((2**len(self.qubits)) / number_of_expected_results))
            for _ in range(number_of_iterations):
                circuit.append(oracle)
                circuit.append(self.diffusion)
            return circuit

def make_oracle(qubits):
    circuit = cirq.Circuit()
    controllee= []
    for i in range(length - 1):
        controllee.append(qubits[i])
    circuit.append(cirq.X(qubits[i]) for i in [1,3,4,6])
    circuit.append(cirq.control(cirq.Z, controllee)(qubits[-1]))
    circuit.append(cirq.X(qubits[i]) for i in [1,3,4,6])
    return circuit


grover = Grover(qubits)
oracle = make_oracle(qubits)
circuit = cirq.Circuit()
circuit.append(cirq.H(q) for q in qubits)
grover.run(circuit, oracle, number_of_expected_results)
circuit.append(cirq.measure(*qubits))

%time
from cirq import Simulator
simulator = Simulator()
result = simulator.run(circuit, repetitions=100)

print(result)
