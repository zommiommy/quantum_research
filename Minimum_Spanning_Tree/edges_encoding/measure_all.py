

from qiskit.circuit.quantumcircuit import QuantumCircuit

def measure_all(circuit : QuantumCircuit) -> QuantumCircuit:
    """Add measure gates to all the intresting registers."""
    start, end, _, membership = circuit.qregs
    classical_start, classical_end, classical_membership = circuit.cregs

    circuit.measure(membership, classical_membership)
    circuit.measure(end, classical_end)
    circuit.measure(start, classical_start)

    return circuit