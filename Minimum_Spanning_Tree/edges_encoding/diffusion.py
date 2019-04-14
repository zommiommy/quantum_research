

from qiskit.circuit.quantumcircuit import QuantumCircuit

from notall import notall
from superposition import superposition
from n_qbits_and import n_qbits_and, n_qbits_and_inverse

def diffusion(circuit : QuantumCircuit) -> QuantumCircuit:
    """Invert all the amplitudes around the means."""
    start, end, ancillas, membership = circuit.qregs

    circuit.barrier()

    # H columns
    circuit = superposition(circuit,[start,end,membership])

    circuit = phase_shift(circuit)      

    # H columns
    circuit = superposition(circuit,[start,end,membership])

    return circuit


def phase_shift(circuit : QuantumCircuit, mode : str = "cnx") -> QuantumCircuit:
    """Change the phase of all the state except the 0 one. (I matrix with all -1 except the first)."""
    start, end, ancillas, membership = circuit.qregs
    # X columns
    circuit = notall(circuit,[start,end,membership])

    circuit.h(membership)


    if mode == "ccnot_tree":
        circuit = n_qbits_and(circuit, [start,end], ancillas)
        circuit.cx(ancillas[len(ancillas) - 1], membership)
        circuit = n_qbits_and_inverse(circuit, [start,end], ancillas)
    elif mode == "cnx" or mode == "mct":
        controlled = [q for register in [start,end] for q in register]
        circuit.cnx(controlled,membership[0],ancillas)
    else:
        raise ValueError("%s it not a recognized mode"%mode)

    circuit.h(membership)
    # X columns
    circuit = notall(circuit,[start,end,membership])
    # End Phase Shift

    return circuit
