

from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit, QuantumRegister

from .notall import notall
from .superposition import superposition
from .n_qbits_and import n_qbits_and, n_qbits_and_inverse

def diffusion(circuit : QuantumCircuit, registers : List[QuantumRegister], ancillas : QuantumRegister) -> QuantumCircuit:
    """Invert all the amplitudes around the means."""

    circuit.barrier()

    # H columns
    circuit = superposition(circuit, registers)

    circuit = phase_shift(circuit, registers, ancillas)      

    # H columns
    circuit = superposition(circuit, registers)

    return circuit


def phase_shift(circuit : QuantumCircuit, registers : List[QuantumRegister], ancillas : QuantumRegister) -> QuantumCircuit:
    """Change the phase of all the state except the 0 one. (I matrix with all -1 except the first)."""
    
    # X columns
    circuit = notall(circuit,registers)

    circuit.h(registers[-1])

    circuit.cnx(registers[:-1], registers[-1],ancillas)

    circuit.h(registers[-1])
    # X columns
    circuit = notall(circuit,registers)
    # End Phase Shift

    return circuit
