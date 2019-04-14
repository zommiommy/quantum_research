

from math import pi, sqrt, floor
from typing import Callable, List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit, QuantumRegister

from .diffusion import diffusion
from .get_logger import get_logger
from .superposition import superposition

logging = get_logger(__name__) 

def grover(circuit : QuantumCircuit, oracle : Callable[[QuantumCircuit],QuantumCircuit], registers : List[QuantumRegister], ancillas : QuantumRegister, number_of_expected_results : int = 1) -> QuantumCircuit:
    """Execute the grover algorithm using the oracle passed to the function."""

    assert number_of_expected_results >= 0, "The number of expected results must be non-negative."

    number_of_qbits = len(registers)
    N = 2**number_of_qbits
    t = number_of_expected_results

    #logging.critical("Gover coefficent k = %d but it's supposed to be 4!"%k)

    number_of_iterations = (pi / 4)*sqrt(N / t)

    logging.info("Grover approx value %f"%(number_of_iterations))

    number_of_iterations = floor(number_of_iterations)

    logging.info("Grover will iterate %d times"%(number_of_iterations))

    circuit = superposition(circuit, registers)

    for _ in range(number_of_iterations):
        circuit = oracle(circuit)
        circuit = diffusion(circuit, registers, ancillas)

    return circuit

