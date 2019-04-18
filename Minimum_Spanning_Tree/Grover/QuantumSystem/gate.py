
import numpy as np

from .tensorproduct import tensor_product
from .latexifier import *

class Gate():

    def __init__(self, base_matrix, n_of_qbits, qbits, name = "", auto_inflate=True, coeff=1, intro=""):
        self.base_matrix = base_matrix
        self.matrix = base_matrix
        self.coeff = coeff
        self.intro = intro
        self.name = name

        if auto_inflate:
            first_iteration = True

            if qbits == []:
                qbits = list(range(n_of_qbits))
            else:
                self.name = name + "(" + ",".join(str(x) for x in qbits) + ")"

            for i in range(n_of_qbits):
                if i in qbits:
                    r = self.base_matrix
                else:
                    r = np.eye(2, dtype=np.complex)
                if first_iteration:
                    self.matrix = r
                    first_iteration = False
                else:
                    self.matrix = tensor_product(self.matrix, r)

    def __call__(self, wave_function, counter, print=True):
        if print and self.name:
            print_to_jupyter(mathify(r"|\psi_{%d}\rangle = %s |\psi_{%d}\rangle"%(counter+1,self.name,counter)))
        result = self.coeff * self.matrix * wave_function
        if print:
            print_operator(self.matrix,wave_function,result,intro=self.intro)
        return result