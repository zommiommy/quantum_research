

from qiskit.circuit.quantumcircuit import QuantumCircuit

from notall import notall
from superposition import superposition
from n_qbits_and import n_qbits_and, n_qbits_and_inverse

def diffusion(circuit : QuantumCircuit) -> QuantumCircuit:
    """Invert all the amplitudes around the means."""
    start, end, ancillas, membership = circuit.qregs

    circuit.barrier()

    # H columns
    circuit.h(start)
    circuit.h(end)
    circuit.h(membership)    

    circuit = phase_shift(circuit)      

    # H columns
    circuit.h(membership)
    circuit.h(end)    
    circuit.h(start)   

    return circuit


def phase_shift(circuit : QuantumCircuit) -> QuantumCircuit:
    """Change the phase of all the state except the 0 one. (I matrix with all -1 except the first)."""
    start, end, ancillas, membership = circuit.qregs
    # X columns
    circuit.x(start)
    circuit.x(end)
    circuit.x(membership)           

    circuit = n_qbits_and(circuit, [start,end], ancillas)     
    
    circuit.cz(ancillas[len(ancillas) - 1], membership)

    circuit = n_qbits_and_inverse(circuit, [start,end], ancillas)
    # X columns
    circuit.x(membership)
    circuit.x(end)    
    circuit.x(start)   
    # End Phase Shift

    return circuit
