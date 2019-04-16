

import qiskit as q
import qiskit_aqua   # import so it modifies the QuantumCircuit object and adds the cnx (mct) gate

from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit


def initialize_circuit(n_of_qbits_for_vertex : int) -> QuantumCircuit:
    """Create the Quantum and Classical registers and initialize the circuit."""
    # Register for the start vertex of the edge
    start = q.QuantumRegister(n_of_qbits_for_vertex, name="start")

    # Register for the end vertex of the edge
    end   = q.QuantumRegister(n_of_qbits_for_vertex, name ="end")

    # Qbit for the flags
    flags = q.QuantumRegister(2, name ="flags")

    # Ancillas Qbits
    ancillas_dim = (2 * n_of_qbits_for_vertex) - 1
    ancillas = q.QuantumRegister(ancillas_dim, name="ancillas")

    # Setup the classical registers to save the result of the measurements
    classical_start = q.ClassicalRegister(n_of_qbits_for_vertex, 'classical_start')
    classical_end   = q.ClassicalRegister(n_of_qbits_for_vertex, 'classical_end')
    classical_flags   = q.ClassicalRegister(2, 'classical_flags')
        
    # Initialize the Citcuit
    circuit = q.QuantumCircuit(start, end, ancillas, flags, classical_start, classical_end, classical_flags)

    return circuit

