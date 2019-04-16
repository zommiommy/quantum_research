

import qiskit as q
from time import time
from pprint import pprint
from typing import List, Tuple
import cpuinfo # To install use pip install py-cpuinfo
from qiskit.circuit.quantumcircuit import QuantumCircuit

from .get_logger import get_logger
from .measure_all import measure_all

logging = get_logger(__name__) 

def rotate_encoding(value):
    return "".join(list(reversed("{:013b}".format(value))))

def symbolic_simulation(circuit : QuantumCircuit) -> None:
    """Calculate the final wave-function."""

    logging.debug("Starting Symbolic Simulation")
    start_time = time()

    backend_sim = q.BasicAer.get_backend('statevector_simulator')
    result = q.execute(circuit, backend_sim, shots=1).result()

    end_time = time()
    logging.debug("The Symbolic Simulation took %f seconds"%(end_time-start_time))

    logging.debug("Printing the states with probability != 0:")
    
    state_list = [(index, value, abs(value)**2) for index, value in enumerate(result.get_statevector(circuit))]

    state_list.sort(key=lambda x: x[-1], reverse=True)

    for index, value, probability in state_list:
        if probability > 1e-6:
            logging.debug("({:+4f} + {:+4f}) |{}> P = {:4f}".format(value.real, value.imag, rotate_encoding(index), probability))
