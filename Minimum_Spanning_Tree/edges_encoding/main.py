

import json                       # Read and write files in json
import numpy as np                # Matrix operations
from math import log2, ceil, floor

from get_logger import get_logger
from find_edge import find_edge

logging = get_logger(__name__) 

file_path = "../test_graph.json"

with open(file_path, "r") as f:
    graph = json.load(f)

n_of_vertices = len(graph)  

# Convert the graph in a list of triples in the form (start, end, weight)
graph = [(start, v[0], v[1]) for start, value in enumerate(graph) for v in value]

logging.info("The Graph is: ")
for values in graph:
    logging.info("\t{} -> {}\t{}".format(*values))

n_of_qbits = ceil(log2(max((e[0] for e in graph))))

logging.info("To encode a vertex we need %d qbits "%n_of_qbits)
logging.info("In total we will need %d qbits"%(4*n_of_qbits))

edge = find_edge(graph, [], n_of_qbits)

logging.info("Result: %s"%str(edge))