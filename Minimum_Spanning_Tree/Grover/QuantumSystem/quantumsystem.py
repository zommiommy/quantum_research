
import numpy as np

from .gate import Gate
from .printer import Printer
from .tensorproduct import tensor_product
from .controloperator import control_operator
from .latexifier import *

class QuantumSystem():
    gates = {
        "H": np.matrix([[1,1],[1,-1]]).astype(np.complex),
        "X": np.matrix([[0,1],[1,0]]).astype(np.complex),
        "Y": np.matrix([[0,-1j],[1j,0]]).astype(np.complex),
        "Z": np.matrix([[1,0],[0,-1]]).astype(np.complex)
    }

    def __init__(self, qbits):
        self.n_of_qbits = qbits
        self.n_of_states = 2**qbits
        self.counter = 0
        self.printer = Printer(qbits)
        self.history = []
        self._print = True

    def enable_printing(self):
        self._print = True

    def disable_printing(self):
        self._print = False

    def print_wave_function(self):
        self.printer.print_wave(self.wave_function, """Wave_function $\psi_{%d}$"""%self.counter)
        self.printer.print_probabilities(self.get_probabilities(self.wave_function), """Probability distribution of $\psi_{%d}$"""%self.counter )

    def initialize_wave_function(self, _print=True):
        self.wave_function = np.matrix(np.zeros((self.n_of_states,1),dtype=np.complex))
        self.wave_function[0] = 1
        if _print:
            print_matrix(self.wave_function, intro=r"|\psi_{%d}\rangle = "%self.counter)
            self.print_wave_function()

    def H(self, qbits = []):
        # Normalize the hadamard gate
        c = 1/((self.n_of_states)**0.5)
        i = r"\frac{1}{\sqrt{%d}}"%self.n_of_states
        self.search_function("H", qbits, coeff=c, intro=i) 

    def X(self, qbits = []):
        self.search_function("X", qbits) 

    def Y(self, qbits = []):
        self.search_function("Y", qbits) 

    def Z(self, qbits = []):
        self.search_function("Z", qbits) 

    def CCZ(self):
        mat = self.gates["Z"]
        for _ in range(self.n_of_qbits - 1):
            mat = control_operator(mat)
        self.apply_function(mat,"CCZ(0,1|2)")


    def C(self,matrix,  name:str, control_qbits = [], controlled_qbits = []):
        """TODO Fix generalization"""
        result = None
        first_iteration = True

        for i in range(self.n_of_qbits):
            if first_iteration:
                if i in controlled_qbits:
                    result = matrix
                else:
                    result = np.eye(2,dtype=np.complex)
                first_iteration = False
            else:
                if i in control_qbits:
                    result = control_operator(result)
                elif i in controlled_qbits:
                    result = tensor_product(result,matrix)
                else:
                    result = tensor_product(result,np.eye(2,dtype=np.complex))

        output =  ("C" * len(control_qbits)) 
        output += (name * len(controlled_qbits))
        output += "(" 
        output += ",".join(str(x) for x in control_qbits)
        output += "|" 
        output += ",".join(str(x) for x in controlled_qbits)
        output += ")"

        self.apply_function(result, name=output) 

    def search_function(self, name, qbits, coeff = 1, intro = ""):
        if name in self.gates.keys():
            g = Gate(self.gates[name],self.n_of_qbits,qbits,name=name,coeff=coeff,intro=intro)
            self.wave_function = g(self.wave_function, self.counter, print=self._print)
            self.counter += 1
            self.history.append((name,qbits))
            if self._print:
                self.print_wave_function()
        else:
            print("[ERROR] Gate %s not found. The available ones are: "%(name,list(self.gates.keys())))


    def get_probabilities(self, wave_function):
        return np.square(np.abs(wave_function))

    def apply_function(self, matrix, name : str = ""):
        g = Gate(matrix,self.n_of_qbits,qbits=None,name=name,auto_inflate=False)
        self.wave_function = g(self.wave_function, self.counter, print=self._print)
        self.counter += 1
        self.history.append((name,[]))
        if self._print:
            self.print_wave_function()

    def print_history(self):
        output = ""
        for i, (name, qbits) in enumerate(self.history):
            if qbits != []:
                name = name + "(" + ",".join(str(x) for x in qbits) + ")"

            print_to_jupyter(mathify(r"|\psi_{%d}\rangle = %s |\psi_{%d}\rangle"%(i+1,name,i)))

    def observe(self):
        p = self.get_probabilities(self.wave_function)
        p = np.array(p).reshape(p.size)
        result = np.random.choice(np.arange(0,self.n_of_states), p=p)
        self.history.append(("OBSERVATION",[]))
        print("Since the state was observed the wave is now destroyed.")
        self.initialize_wave_function(_print=False)
        return result