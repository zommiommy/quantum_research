

import logging
import qiskit as q
from time import time
from pprint import pprint
from typing import List, Tuple
from measure_all import measure_all
import cpuinfo # To install use pip install py-cpuinfo
from qiskit.circuit.quantumcircuit import QuantumCircuit

logging = logging.getLogger(__name__) 

def rotate_encoding(value):
    return "".join(list(reversed("{:012b}".format(value))))

def symbolic_simulation(circuit : QuantumCircuit) -> None:
    """Calculate the final wave-function."""

    logging.debug("Starting Symbolic Simulation")
    start_time = time()

    backend_sim = q.BasicAer.get_backend('statevector_simulator')
    result = q.execute(circuit, backend_sim, shots=1).result()

    end_time = time()
    logging.debug("The Symbolic Simulation took %f seconds"%(end_time-start_time))

    logging.debug("Printing the states with probability != 0:")

    for index, value in enumerate(result.get_statevector(circuit)):
        probability = abs(value)**2
        if probability > 0:
            logging.debug("({:+4f} + {:+4f}) |{}> P = {:4f}".format(value.real, value.imag, rotate_encoding(index), probability))
