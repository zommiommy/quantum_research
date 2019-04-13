

from typing import List
from math import ceil, floor
from qiskit.circuit.quantumcircuit import QuantumCircuit
from qiskit.circuit.quantumregister import QuantumRegister

def n_qbits_and(circuit : QuantumCircuit, registers :  List[QuantumRegister], ancillas : QuantumRegister) -> QuantumCircuit:
    """Compute the and of all the qbits in the register, the ancillas qbits must be all at 0 and the result is in the last one."""

    qbits = [qbit for registers_list in [registers, [ancillas]] for register in registers_list for qbit in register]

    n_of_qbits = len(qbits)

    size_of_registers = sum((register.size for register in registers))

    assert ancillas.size >= size_of_registers - 1, "The ancilla register is not big enought! it's only %d qbits when it sould be at least %d. qbits."%(ancillas.size,size_of_registers - 1)

    input_index = 0
    result_index = ceil(n_of_qbits/2)
    
    while input_index < result_index-1:
        circuit.ccx(qbits[input_index],qbits[input_index + 1], qbits[result_index])
        input_index  += 2
        result_index += 1

    return circuit


def n_qbits_and_inverse(circuit : QuantumCircuit, registers :  List[QuantumRegister], ancillas : QuantumRegister) -> QuantumCircuit:
    """Reverse the computation of n_qbits_and with the same arguments."""

    qbits = [qbit for registers_list in [registers, [ancillas]] for register in registers_list for qbit in register]

    n_of_qbits = len(qbits)

    size_of_registers = sum((register.size for register in registers))

    assert ancillas.size >= size_of_registers - 1, "The ancilla register is not big enought! it's only %d qbits when it sould be at least %d. qbits."%(ancillas.size,size_of_registers - 1)

    input_index = n_of_qbits - 3
    result_index = n_of_qbits - 1

    while input_index >= 0:
        circuit.ccx(qbits[input_index],qbits[input_index+1], qbits[result_index])
        input_index  -= 2
        result_index -= 1

    return circuit