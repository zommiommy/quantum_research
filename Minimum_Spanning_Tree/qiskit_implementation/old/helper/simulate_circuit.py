

import json
import qiskit as q
from time import time
from pprint import pprint
from collections import Counter
from math import log2, ceil, floor
from typing import List, Tuple, Dict
import cpuinfo # To install use pip install py-cpuinfo
from qiskit.circuit.quantumcircuit import QuantumCircuit

from .get_logger import get_logger
from .time_function import time_function

logging = get_logger(__name__) 

@time_function
def save_circuit_image(circuit :QuantumCircuit,  circuit_image_path : str = "circuit.png") -> None:
    circuit.draw(output="mpl",filename=circuit_image_path,scale=(1/2**4))


@time_function
def save_circuit_qasm(circuit : QuantumCircuit, circuit_QASM_path : str = "circuit.qasm") -> None:
    logging.info("Saving the circuit as QASM")

    with open(circuit_QASM_path,"w") as f:
        f.write(circuit.qasm())

@time_function
def parallel_simulation(circuit : QuantumCircuit, n_of_shots : int , n_of_threads : int = 4) -> Dict[str,int]:
    backend = q.Aer.get_backend("qasm_simulator")

    job_shots = int(n_of_shots / n_of_threads)

    qobj_list = [q.compile(circuit, backend, shots=job_shots) for _ in range(n_of_threads)]

    logging.info("Starting %d simulation threads."%n_of_threads)

    job_list = [backend.run(qobj) for qobj in qobj_list]

    count = {}

    while job_list:
        for job in job_list:
            if job.status() == q.providers.JobStatus.DONE:
                logging.info("A thread finished.")
                job_list.remove(job)
                for key, item in job.result().get_counts().items():
                    count[key] = count.get(key, 0) + item

    return count

@time_function
def normal_simulation(circuit : QuantumCircuit, n_of_shots : int) -> Dict[str,int]:
    # Initialize the BackEnd
    backend_sim = q.BasicAer.get_backend('qasm_simulator')

    qobj = q.compile(circuit, backend_sim, shots=n_of_shots)

    result = backend_sim.run(qobj).result()

    counts = result.get_counts(circuit)

    return counts


def save_the_results(count : Dict[str,int], filepath : str = "results.json") -> None:
    logging.info("Saving the results to %s"%filepath)
    with open(filepath,"w") as f:
        json.dump(count, f,indent=4)

def get_MLE(counts :  Dict[str,int]) -> Tuple[int,int,int,int]:
    """Find the most frequent result with the flags setted to 1 (MLE)"""
    logging.info("Finding the Most Likley result")
    # Convert it to a list
    result_list = [list(reversed(encoding.split(" "))) + [times] for encoding, times in counts.items()]

    result_list.sort(key=lambda x: x[-1], reverse=True)

    logging.debug("The results are: ")

    result_list = [(int(values[0],base=2),int(values[1],base=2),int(values[2],base=2),int(values[3])) for values in result_list]

    for values in result_list:
        logging.debug("\t{:d} -> {:d} flags: {:02b} times: {:d}".format(*values))

    MLE =  max(result_list,key=lambda x: x[-1]) #  if x[-2] == 1 else 0

    logging.info("The Most Likley result is {} -> {} flags: {:02b} times: {}".format(*MLE))
    return MLE


def simulate_circuit(graph : List[Tuple[int,int,float]], circuit : QuantumCircuit, n_of_shots : int = (100*2**7), parallel : bool = True) -> Tuple[int, int]:
    """Simulate the circuit and take the most frequent feasible result."""
        
    logging.info("Starting to simulate on %s"%(cpuinfo.get_cpu_info()["brand"]))

    save_circuit_qasm(circuit)

    logging.info("Starting Simulation")

    logging.info("Starting a batch of %d Executions"%(n_of_shots))

    if parallel:
        count = parallel_simulation(circuit,n_of_shots)
    else:
        count = normal_simulation(circuit,n_of_shots)

    save_the_results(count)

    MLE = get_MLE(count)


    return MLE[0], MLE[1]