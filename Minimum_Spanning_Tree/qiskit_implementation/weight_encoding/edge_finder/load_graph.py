

import json                       # Read and write files in json
import numpy as np                # Matrix operations
from math import log2, ceil, floor

from .get_logger import get_logger

logger = get_logger(__name__) 


def load_graph(file_path : str = "../../test_graph.json"):

    with open(file_path, "r") as f:
        graph = json.load(f)

    n_of_vertices = len(graph)  

    graph = [(start, v[0], v[1]) for start, value in enumerate(graph) for v in value]

    logger.info("The Graph is: ")

    for values in graph:
        logger.info("\t{} -> {}\t{}".format(*values))

    return graph