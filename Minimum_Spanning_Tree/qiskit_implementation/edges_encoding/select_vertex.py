
import qiskit
import qiskit_aqua
import qiskit as q

from edge_finder import EdgeFinder
from edge_finder import encode_graph
from edge_finder import select_value
from edge_finder import encode_value, encode_value_inverse
from edge_finder import get_logger

logger = get_logger(__name__)


class SelectVertex(EdgeFinder):

    def setup_oracle(self):
        self.oracle  = q.QuantumCircuit(*self.qregisters)

        self.oracle.barrier()

        # Encode the graph
        self.oracle = encode_graph(self.oracle, self.graph, self.start, self.end, self.flags[0], self.ancillas)

        self.oracle.barrier()

        # Select the starting vertex to be == 1
        self.oracle = encode_value(self.oracle,  self.start, 1, self.ancillas)

        controlled = [q for register in [self.start, [self.flags[0]]] for q in register]
        self.oracle.cnx(controlled,self.flags[1],self.ancillas)

        self.oracle = encode_value_inverse(self.oracle,  self.start, 1, self.ancillas)

        self.oracle.barrier()

        # Apply the change the phase of the wanted values

        self.oracle.cz(self.flags[0], self.flags[1])

        self.oracle.barrier()
        


if __name__ == "__main__":
    t = SelectVertex()
    edge = t.run()
    logger.info("Result: {}".format(edge))