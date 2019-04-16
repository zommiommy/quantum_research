

import qiskit as q
import qiskit_aqua

from typing import List
from math import floor, pi, sqrt
from qiskit import QuantumCircuit, QuantumRegister

from .get_logger import get_logger

logger = get_logger(__name__)



class Grover():
    def __init__(self, registers : List[QuantumRegister], ancillas : QuantumRegister) -> None:
        """Initialize the grover algorithm. 
        Grover(
            registers : List[QuantumRegister],
            ancillas : QuantumRegister
            )"""
        self.ancillas = ancillas
        self.registers = registers
        self.qbits = [qbit for register in registers for qbit in register]
        self.diffusion = self._construct_diffusion()


    def _construct_diffusion(self) -> QuantumCircuit:
        """Create the diffusion circuit for the registers."""
        
        logger.debug("Creating the diffusion circuit")

        circuit = q.QuantumCircuit(*self.registers, self.ancillas)

        for qbit in self.qbits:
            circuit.h(qbit)
            circuit.x(qbit)

        circuit.h(self.qbits[-1])
        circuit.cnx(self.qbits[:-1], self.qbits[-1],self.ancillas)
        circuit.h(self.qbits[-1])

        for qbit in self.qbits:
            circuit.x(qbit)
            circuit.h(qbit)

        return circuit

    
    def run(self, circuit : QuantumCircuit, oracle : QuantumCircuit, number_of_expected_results : int = 1) -> QuantumCircuit:

        number_of_iterations = (pi / 4)*sqrt((2**len(self.qbits)) / number_of_expected_results)

        logger.info("Grover approx value %f"%(number_of_iterations))

        number_of_iterations = floor(number_of_iterations)

        logger.info("Grover will iterate %d times"%(number_of_iterations))

        for _ in range(number_of_iterations):
            circuit += oracle
            circuit += self.diffusion

        return circuit