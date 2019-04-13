

from qiskit.circuit.quantumcircuit import QuantumCircuit

def superposition(circuit : QuantumCircuit) -> QuantumCircuit:
    """Apply the hadamard gate on every qbits of the system to get a superposition."""

    for register in circuit.qregs:
        circuit.h(register) # It works also on all the register

    return circuit