
import qiskit
import qiskit_aqua
import qiskit as q

from edge_finder import EdgeFinder
from edge_finder import encode_graph
from edge_finder import select_value
from edge_finder import get_logger

logger = get_logger(__name__)


class GroverTest(EdgeFinder):

    def initialize_circuit(self):
        """Prepare the initial superposition"""
        for register in [self.start, self.end, self.flags]:
            self.circuit.h(register)

    def setup_oracle(self):
        self.oracle  = q.QuantumCircuit(*self.qregisters)
        self.oracle.barrier()

        self.oracle.x(self.start[0])
        self.oracle.x(self.end[1])
        self.oracle.x(self.flags[0])

        self.oracle.h(self.flags[1])
        controlled = [q for register in [self.start, self.end, [self.flags[0]]] for q in register]
        self.oracle.cnx(controlled ,self.flags[1],self.ancillas)
        self.oracle.h(self.flags[1])

        self.oracle.x(self.flags[0])
        self.oracle.x(self.end[1])
        self.oracle.x(self.start[0])
        
        self.oracle.barrier()

if __name__ == "__main__":
    t = GroverTest()
    edge = t.run()
    logger.info("Result: {}".format(edge))