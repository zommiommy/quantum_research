

from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit

from .encode_value import encode_value, encode_value_inverse
from .n_qbits_and import n_qbits_and, n_qbits_and_inverse

def encode_edge(circuit : QuantumCircuit, start_value : int, end_value : int, weight_value : float, mode : str = "cnx") -> QuantumCircuit:
    """Encode all the edges of the graph."""

    start, end, ancillas, flags = circuit.qregs

    circuit.barrier()

    circuit = encode_value(circuit, start, start_value)
    circuit = encode_value(circuit, end, end_value)

    # Simulate the Big C^nNOT

    if mode == "ccnot_tree":
        circuit = n_qbits_and(circuit, [start,end], ancillas)
        circuit.cx(ancillas[len(ancillas) - 1], flags)
        circuit = n_qbits_and_inverse(circuit, [start,end], ancillas)
    elif mode == "cnx" or mode == "mct":
        controlled = [q for register in [start,end] for q in register]
        circuit.cnx(controlled,flags[0],ancillas)
    else:
        raise ValueError("%s it not a recognized mode"%mode)


    # Reverse the computation

    
    circuit = encode_value_inverse(circuit, end, end_value)
    circuit = encode_value_inverse(circuit, start, start_value)

    return circuit