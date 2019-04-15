

import qiskit as q
from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit, QuantumRegister

from helper import grover
from helper import get_logger
from helper import measure_all
from helper import encode_graph
from helper import simulate_circuit
from helper import initialize_circuit
from helper import symbolic_simulation

logging = get_logger(__name__) 

def select_vertex(circuit : QuantumCircuit, register : QuantumRegister, value : int, flags : QuantumRegister, ancillas : QuantumRegister) -> QuantumCircuit:

    encoder = "{:0" + str(register.size) + "b}"

    encoding = encoder.format(value)

    for qbit, binary_value in zip(register, encoding):
        if binary_value == '0':
            circuit.x(qbit)

    circuit.h(flags[len(flags)-1])
    controlled = [q for register in [register,flags] for q in register][:-1]
    circuit.cnx(controlled, flags[len(flags)-1], ancillas)
    circuit.h(flags[len(flags)-1])

    for qbit, binary_value in zip(register, encoding):
        if binary_value == '0':
            circuit.x(qbit)

    return circuit

def find_edge(graph : List[Tuple[int, int, float]], current_mst : List[Tuple[int, int, float]], n_of_qbits_for_vertex : int = 3) -> Tuple[int, int]:
    """Quantum search algorithm to find an edge."""

    logging.info("Initializing the Circuit")

    circuit = initialize_circuit(n_of_qbits_for_vertex)

    logging.info("Creating the oracle")

    def oracle(circuit : QuantumCircuit) -> QuantumCircuit:
        """The oracle to find the edge."""
        start, end, ancillas, flags = circuit.qregs

        circuit = encode_graph(circuit, graph)

        # Select all the edges that start from 7

        circuit = select_vertex(circuit, start, 7, flags, ancillas)

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