

from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit, QuantumRegister

def superposition(circuit : QuantumCircuit, registers : List[QuantumRegister] = None) -> QuantumCircuit:
    """Apply the hadamard gate on every qbits of the system to get a superposition."""

    if registers == None:
        registers = circuit.qregs

    for register in registers:
        circuit.h(register) # It works also on all the register

    return circuit