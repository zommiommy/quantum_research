

import logging
import qiskit as q
from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit

from grover import grover
from measure_all import measure_all
from encode_graph import encode_graph
from simulate_circuit import simulate_circuit
from initialize_circuit import initialize_circuit
from symbolic_simulation import symbolic_simulation

logging = logging.getLogger(__name__) 

def find_edge(graph : List[Tuple[int, int, float]], current_mst : List[Tuple[int, int, float]], n_of_qbits_for_vertex : int = 3) -> Tuple[int, int]:
    """Quantum search algorithm to find an edge."""

    logging.info("Initializing the Circuit")

    circuit = initialize_circuit(n_of_qbits_for_vertex)

    logging.info("Creating the oracle")

    def oracle(circuit : QuantumCircuit) -> QuantumCircuit:
        """The oracle to find the edge."""
        start, end, ancillas, membership = circuit.qregs

        circuit = encode_graph(circuit, graph)

        circuit.z(membership)

        return circuit

    logging.info("Applying grover")

    circuit = grover(circuit, oracle, number_of_expected_results=len(graph))

    symbolic_simulation(circuit)

    logging.info("Adding Measure gates")

    circuit = measure_all(circuit)

    logging.info("The final circuit has %d depth and %d gates"%(circuit.depth(), circuit.size()))

    return simulate_circuit(circuit)