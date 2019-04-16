

import logging
import qiskit as q
from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit

from grover import grover
from measure_all import measure_all
from encode_graph import encode_graph
from simulate_circuit import simulate_circuit
from initialize_circuit import initialize_circuit

logging = logging.getLogger(__name__) 

def find_edge(graph : List[Tuple[int, int, float]], current_mst : List[Tuple[int, int, float]], n_of_qbits_for_vertex : int = 3) -> Tuple[int, int]:
    """Quantum search algorithm to find an edge."""

    logging.info("Initializing the Circuit")

    circuit = initialize_circuit(n_of_qbits_for_vertex)

    logging.info("Creating the oracle")

    start, end, ancillas, membership = circuit.qregs

    circuit = encode_graph(circuit, graph)

    circuit.z(membership)

    logging.info("Applying grover")

    print(grover(oracle).run())
        
    return simulate_circuit(circuit)