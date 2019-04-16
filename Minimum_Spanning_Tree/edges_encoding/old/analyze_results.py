


import json
import qiskit as q
from time import time
from pprint import pprint
from collections import Counter
from math import log2, ceil, floor
from typing import List, Tuple, Dict
import cpuinfo # To install use pip install py-cpuinfo
from qiskit.circuit.quantumcircuit import QuantumCircuit

from helper import get_logger
from helper  import time_function

logging = get_logger(__name__) 



def analyze_results(graph : List[Tuple[int,int,float]], count : Dict[str,int]) -> None:
    """Analyze the likleyhood of the results"""
    successes = sum(map(lambda x: x[1],filter(lambda x: x[0][0] == "1", count.items())))
    total_extractions = sum(count.values())

    p_success = successes/total_extractions

    logging.info("Success rate: %f"%p_success)

    n_graph_edges = len(graph)
    n_of_qbits = ceil(log2(max((e[0] for e in graph))))

    p_graph = n_graph_edges / ((2*n_of_qbits)**2)

    logging.info("Edges distribution: %f"%p_graph)

    accuracy =  p_success / p_graph

    logging.info("Accuracy: %f"%accuracy)
