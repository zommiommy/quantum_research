

import qiskit as q
from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit

from helper import grover
from helper import get_logger
from helper import measure_all
from helper import encode_graph
from helper import simulate_circuit
from helper import initialize_circuit
from helper import symbolic_simulation

logging = get_logger(__name__) 

def find_edge(graph : List[Tuple[int, int, float]], current_mst : List[Tuple[int, int, float]], n_of_qbits_for_vertex : int = 3) -> Tuple[int, int]:
    """Quantum search algorithm to find an edge."""

    logging.info("Initializing the Circuit")

    circuit = initialize_circuit(n_of_qbits_for_vertex)

    logging.info("Creating the oracle")

    def oracle(circuit : QuantumCircuit) -> QuantumCircuit:
        """The oracle to find the edge."""
        start, end, ancillas, flags = circuit.qregs

        circuit = encode_graph(circuit, graph)
        circuit.z(flags)

        return circuit

    logging.info("Applying grover")

    start, end, ancillas, flags = circuit.qregs
    registers = [q for register in [start,end, flags] for q in register]

    circuit = grover(circuit, oracle, registers, ancillas, number_of_expected_results=len(graph))

    symbolic_simulation(circuit)

    logging.info("Adding Measure gates")

    circuit = measure_all(circuit)

    logging.info("The final circuit has %d depth and %d gates"%(circuit.depth(), circuit.size()))

    return simulate_circuit(graph, circuit)