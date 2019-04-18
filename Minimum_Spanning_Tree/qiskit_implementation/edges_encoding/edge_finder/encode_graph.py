


from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit, QuantumRegister


def rotate_bits(value : int) -> str:
    return str(value)[::-1]

def encode_value(circuit : QuantumCircuit, register : QuantumRegister, value : int, ancillas : QuantumRegister, reverse : bool = True) -> QuantumCircuit:
    """Encode an integer value in the register."""

    encoder = "{:0" + str(len(register)) + "b}"

    encoding = encoder.format(value)

    if reverse:
        encoding = rotate_bits(encoding)

    for qbit, binary_value in zip(register, encoding):
        if binary_value == '0':
            circuit.x(qbit)

    return circuit


encode_value_inverse = encode_value

def select_value(circuit : QuantumCircuit, register : QuantumRegister, value : int, target : QuantumRegister, ancillas : QuantumRegister):
    circuit.barrier()
    circuit = encode_value(circuit, register, value, ancillas)
    circuit.cnx(register,target,ancillas)
    circuit = encode_value_inverse(circuit, register, value, ancillas)
    return circuit
    
def encode_edge(circuit : QuantumCircuit, start : QuantumRegister, start_value : int, end : QuantumRegister, end_value : int, target : QuantumRegister, ancillas : QuantumRegister) -> QuantumCircuit:
    """Encode all the edges of the graph. |i>|j>|0> -> |i>|j>|A_{ij}>"""

    circuit.barrier()

    circuit = encode_value(circuit, start, start_value, ancillas)
    circuit = encode_value(circuit, end, end_value, ancillas)

    # Simulate the Big C^nNOT

    controlled = [q for register in [start,end] for q in register]
    circuit.cnx(controlled,target,ancillas)
    # Reverse the computation
    
    circuit = encode_value_inverse(circuit, end, end_value, ancillas)
    circuit = encode_value_inverse(circuit, start, start_value, ancillas)

    return circuit

def encode_graph(circuit : QuantumCircuit, graph : List[Tuple[int, int, float]], start : QuantumRegister, end : QuantumRegister, target : QuantumRegister, ancillas : QuantumRegister) -> QuantumCircuit:
    """Encode all the edges of the graph."""
    
    for start_val, end_val, _ in graph:
        circuit = encode_edge(circuit, start, start_val, end, end_val, target, ancillas)

    return circuit