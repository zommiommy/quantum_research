
from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit
from qiskit.circuit.quantumregister import QuantumRegister

def encode_value(circuit : QuantumCircuit, register : QuantumRegister, value : int) -> QuantumCircuit:
    """Encode an integer value in the register."""

    start, end, ancillas, flags = circuit.qregs

    encoder = "{:0" + str(register.size) + "b}"

    encoding = encoder.format(value)

    for qbit, binary_value in zip(register, encoding):
        if binary_value == '0':
            circuit.x(qbit)

    return circuit


encode_value_inverse = encode_value
    