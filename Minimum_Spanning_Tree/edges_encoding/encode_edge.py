

from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit

from encode_value import encode_value, encode_value_inverse
from n_qbits_and import n_qbits_and, n_qbits_and_inverse

def encode_edge(circuit : QuantumCircuit, start_value : int, end_value : int, weight_value : float) -> QuantumCircuit:
    """Encode all the edges of the graph."""

    start, end, ancillas, membership = circuit.qregs

    circuit.barrier()

    circuit = encode_value(circuit, start, start_value)
    circuit = encode_value(circuit, end, end_value)

    # Simulate the Big C^nNOT

    circuit = n_qbits_and(circuit, [start,end], ancillas)

    circuit.cx(ancillas[len(ancillas) - 1], membership)

    # Reverse the computation

    circuit = n_qbits_and_inverse(circuit, [start,end], ancillas)
    
    circuit = encode_value_inverse(circuit, end, end_value)
    circuit = encode_value_inverse(circuit, start, start_value)

    return circuit