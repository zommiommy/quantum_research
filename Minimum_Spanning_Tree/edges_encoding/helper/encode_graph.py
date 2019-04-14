

from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit

from .encode_edge import encode_edge

def encode_graph(circuit : QuantumCircuit, graph : List[Tuple[int, int, float]]) -> QuantumCircuit:
    """Encode all the edges of the graph."""
    
    for start, end, weight in graph:
        circuit = encode_edge(circuit, start, end, weight)

    return circuit