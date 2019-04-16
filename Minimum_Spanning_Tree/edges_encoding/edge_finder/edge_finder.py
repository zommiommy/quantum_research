

import qiskit as q
import qiskit_aqua
from math import ceil, log2
from typing import Dict, Tuple

from .grover import Grover
from .simulator import Simulator
from .load_graph import load_graph
from .get_logger import get_logger

from .encode_graph import *


logger = get_logger(__name__) 


class EdgeFinder():

    def __init__(self):
        self.graph = load_graph()
        self.n_of_qbits = ceil(log2(max((e[0] for e in self.graph))))
        logger.info("To encode a vertex we need %d qbits "%self.n_of_qbits)
        self._setup_registers()
        self._setup_circuit()

    def _setup_registers(self):

        # Quantum registers
        self.start = q.QuantumRegister(self.n_of_qbits, name="start")
        self.end   = q.QuantumRegister(self.n_of_qbits, name ="end")
        self.flags = q.QuantumRegister(2, name ="flags")
        self.ancillas_dim = (2 * self.n_of_qbits) - 1
        self.ancillas = q.QuantumRegister(self.ancillas_dim, name="ancillas")

        self.qregisters = [self.start, self.end, self.flags, self.ancillas]

        # Setup the classical registers to save the result of the measurements
        self.classical_start = q.ClassicalRegister(self.n_of_qbits, 'classical_start')
        self.classical_end   = q.ClassicalRegister(self.n_of_qbits, 'classical_end')
        self.classical_flags = q.ClassicalRegister(2, 'classical_flags')
            
        self.cregisters = [self.classical_start, self.classical_end, self.classical_flags]


    def _setup_circuit(self):
        self.circuit = q.QuantumCircuit(*self.qregisters,*self.cregisters)

    def _add_measure_gates(self):
        logger.info("Adding measure gates")
        for q, c in zip(self.qregisters, self.cregisters):
            self.circuit.measure(q, c)

    def setup_oracle(self):
        self.oracle = None
        raise NotImplementedError("This method is met to be overvritten by a subclass therfore is not callable.")

    def get_MLE(self, counts : Dict[int, int]) -> Tuple[int, int, int]:
        """Find the most frequent result with the flags setted to 1 (MLE)"""
        logger.info("Finding the Most Likley result")
        # Convert it to a list
        result_list = [list(reversed(encoding.split(" "))) + [times] for encoding, times in counts.items()]

        result_list.sort(key=lambda x: x[-1], reverse=False)

        logger.debug("The results are: ")

        result_list = [(int(values[0],base=2),int(values[1],base=2),int(values[2],base=2),int(values[3])) for values in result_list]

        for values in result_list:
            logger.debug("\t{:d} -> {:d} flags: {:02b} times: {:d}".format(*values))

        MLE =  max(result_list,key=lambda x: x[-1]) #  if x[-2] == 1 else 0

        logger.info("The Most Likley result is {} -> {} flags: {:02b} times: {}".format(*MLE))
        return MLE

    def run(self, n_of_shots : int = 100*(2**7)):

        for register in [self.start, self.end]:
            self.circuit.h(register)

        self.setup_oracle()

        logger.info("Checking if the oracle is correct:")
        simulator = Simulator()
        simulator.symbolic_simulation(self.circuit + self.oracle)

        self.circuit = Grover([self.start, self.end, self.flags], self.ancillas).run(self.circuit, self.oracle)

        self._add_measure_gates()

        logger.info("Starting a batch of %d simulations."%n_of_shots)

        results = simulator.distribuited_simulation(self.circuit, n_of_shots, [("localhost",9999,4)])
        #results = simulator.parallel_simulation(self.circuit, n_of_shots)
        simulator.save_results()

        return self.get_MLE(results)
