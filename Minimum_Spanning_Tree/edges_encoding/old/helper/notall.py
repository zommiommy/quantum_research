

from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit, QuantumRegister

def notall(circuit : QuantumCircuit, registers : List[QuantumRegister] = None) -> QuantumCircuit:
    """Apply the X gate on every qbits of the system to get NOT all the qbits."""

    if registers == None:
        registers = circuit.qregs

    for register in registers:
        circuit.x(register) # It works also on all the register

    return circuit