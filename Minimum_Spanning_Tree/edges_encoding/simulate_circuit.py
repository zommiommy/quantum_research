

import logging
import qiskit as q
from time import time
from pprint import pprint
from typing import List, Tuple
import cpuinfo # To install use pip install py-cpuinfo
from qiskit.circuit.quantumcircuit import QuantumCircuit

logging = logging.getLogger(__name__) 

def save_circuit_image(circuit :QuantumCircuit,  circuit_image_path : str = "circuit.png") -> None:
    logging.info("Saving the circuit as an Image")
    
    start_time = time()

    circuit.draw(output="mpl",filename=circuit_image_path,scale=(1/2**4))

    end_time = time()
    logging.info("The Circuit Image %s took %f seconds"%(circuit_image_path,(end_time-start_time)))



def save_circuit_qasm(circuit : QuantumCircuit, circuit_QASM_path : str = "circuit.qasm") -> None:
    logging.info("Saving the circuit as QASM")

    start_time = time()

    with open(circuit_QASM_path,"w") as f:
        f.write(circuit.qasm())

    end_time = time()
    logging.info("The Circuit QASM %s took %f seconds"%(circuit_QASM_path,(end_time-start_time)))

def simulate_circuit(circuit : QuantumCircuit, n_of_shots : int = 10) -> Tuple[int, int]:
    """Simulate the circuit and take the most frequent feasible result."""
        
    logging.info("Starting to simulate on %s"%(cpuinfo.get_cpu_info()["brand"]))

    save_circuit_qasm(circuit)

    logging.info("Starting Simulation")

    # Initialize the BackEnd
    backend_sim = q.BasicAer.get_backend('qasm_simulator')

    logging.info("Starting a batch of %d Executions"%(n_of_shots))
    # Simulate all

    start_time = time()

    result = q.execute(circuit, backend_sim, shots=n_of_shots).result()

    end_time = time()

    logging.info("Execution endend. It took %f seconds"%(end_time - start_time))

    # Get the frequencies of outcome of the "experimentals" results
    logging.info("Clearing the Results")
    counts = result.get_counts(circuit)

    # Convert it to a list
    result_list = [list(reversed(encoding.split(" "))) + [times] for encoding, times in counts.items()]
    
    logging.debug("The results are: ")

    for values in result_list:
        values = [int(values[0],base=2),int(values[1],base=2),int(values[2],base=2),int(values[3])]
        logging.debug("\t{:d} -> {:d} membership: {:d} times: {:d}".format(*values))

    # Find the most frequent result with the membership setted to 1 (MLE)
    MLE = max(result_list,key=lambda x: x[-1]) #  if x[-2] == 1 else 0
    # Separate the results in the registers
    start, end, membership, times = MLE

    logging.info("The Most Likley result is {} -> {} membership: {} times: {}".format(*MLE))

    return int(start, base=2), int(end, base=2)