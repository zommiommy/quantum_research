
from time import time
import json                       # Read and write files in json
import numpy as np                # Matrix operations
from math import log2, ceil, floor

from helper.get_logger import get_logger
from find_edge import find_edge

logging = get_logger(__name__) 



import qiskit as q
import numpy as np
from tqdm import tqdm
from typing import List, Tuple
from qiskit.circuit.quantumcircuit import QuantumCircuit

from helper import grover
from helper import get_logger
from helper import measure_all
from helper import encode_graph
from helper import simulate_circuit
from helper import initialize_circuit
from helper import symbolic_simulation

logging = get_logger(__name__) 

logging.info("Initializing the Circuit")

circuit = initialize_circuit(3)

logging.info("Creating the oracle")

def oracle(circuit : QuantumCircuit) -> QuantumCircuit:
    """The oracle to find the edge."""
    start, end, ancillas, membership = circuit.qregs

    circuit.h(membership)
    controlled = [q for register in [start,end] for q in register]
    circuit.cnx(controlled,membership[0],ancillas)
    circuit.h(membership)

    return circuit

logging.info("Applying grover")
start, end, ancillas, membership = circuit.qregs
registers = [q for register in [start,end, membership] for q in register]

circuit = grover(circuit, oracle, registers, ancillas, number_of_expected_results=1)


# symbolic_simulation(circuit)

logging.info("Adding Measure gates")

circuit = measure_all(circuit)

logging.info("The final circuit has %d depth and %d gates"%(circuit.depth(), circuit.size()))

res = simulate_circuit(None, circuit)

results_analisis = []


edge = grover_test()
with open("results.json", "r") as f:
    results = json.load(f)

searched = results["1 111 111"]
total = sum(results.values())
mean = total / (2**7)
var = np.var([int(x) for x in results.values()])
std = var**0.5
normalized_value = (searched - mean) / std

temp = {
    "n_of_iterations":k,
    "searched":searched,
    "total":total,
    "mean":mean,
    "var":var,
    "std":std,
    "normalized_value":normalized_value
}

logging.critical(temp)
