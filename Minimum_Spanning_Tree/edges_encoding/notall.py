

from qiskit.circuit.quantumcircuit import QuantumCircuit

def notall(circuit : QuantumCircuit) -> QuantumCircuit:
    """Apply the X gate on every qbits of the system to get NOT all the qbits."""

    for register in circuit.qregs:
        circuit.x(register) # It works also on all the register

    return circuit