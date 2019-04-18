

from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit, QuantumRegister

from .encode_value import encode_value, encode_value_inverse
from .n_qbits_and import n_qbits_and, n_qbits_and_inverse

def encode_edge(circuit : QuantumCircuit, start_value : int, end_value : int, weight_value : float, target : QuantumRegister) -> QuantumCircuit:
    """Encode all the edges of the graph."""

    start, end, ancillas, flags = circuit.qregs

    circuit.barrier()

    circuit = encode_value(circuit, start, start_value)
    circuit = encode_value(circuit, end, end_value)

    # Simulate the Big C^nNOT

    controlled = [q for register in [start,end] for q in register]
    circuit.cnx(controlled,target,ancillas)
    # Reverse the computation

    
    circuit = encode_value_inverse(circuit, end, end_value)
    circuit = encode_value_inverse(circuit, start, start_value)

    return circuit