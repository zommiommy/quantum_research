import numpy as np
import matplotlib.pyplot as plt
from IPython.display import display, Math

class QuantumSystem():
    base_hadamard = np.matrix([[1,1],[1,-1]])
    base_x = np.matrix([[0,1],[1,0]])
    base_y = np.matrix([[0,-1j],[1j,0]])
    base_z = np.matrix([[1,0],[0,-1]])
    _print = True

    def set_n_of_qbits(self, qbits : int):
        self.n_of_qbits = qbits
        self.n_of_states = 2**qbits
        self.initialize_gates()

    def enable_printing(self):
        self._print = True

    def disable_printing(self):
        self._print = False

    def control_operator(self, matrix):
        x1, y1  = matrix.shape
        x, y = 2*x1, 2* y1
        result = np.eye(x)
        result[-x1:,-y1:] = matrix
        return result

    def initialize_gates(self):
        self.hadamard = self.base_hadamard
        self.x = self.base_x
        self.y = self.base_y
        self.z = self.base_z
        for _ in range(self.n_of_qbits - 1):
            self.hadamard = self.tensor_product(self.hadamard,self.base_hadamard)
            self.x = self.tensor_product(self.x,self.base_x)
            self.y = self.tensor_product(self.y,self.base_y)
            self.z = self.tensor_product(self.z,self.base_z)
        # Normalize the hadamard gate
        self.hadamard /= ((self.n_of_states)**0.5)

    def print_wave_function(self):
        self._print_graph(self.wave_function, """Wave function $\psi$""")

    def _latex_rappresentation(self, matrix):
        output = r"\begin{pmatrix}"
        for row in matrix:
            for value in np.array(row).reshape(row.size):
                output += str(round(value,3))
                output += " & "
            # Cancell the excessive &
            output = output[:-2]
            output += r"\\"
        # Cancell the excessive \\
        output = output[:-2]
        output += r"\end{pmatrix}"
        return output

    def _print_to_jupyter(self, string):
        display(Math(string))

    def print_matrix(self, matrix, intro = r"|\psi\rangle = "):
        output = intro +  self._latex_rappresentation(matrix)
        self._print_to_jupyter(output)

    def _print_step(self, matrix, vector, result):
        string = self._latex_rappresentation(matrix)
        string += self._latex_rappresentation(vector)
        string += " = "
        string += self._latex_rappresentation(result)
        self._print_to_jupyter(string)


    def _print_graph(self, amplitudes, title : str):
        x = np.arange(self.n_of_states)
        plt.figure(figsize=(15,5))
        plt.bar(x,np.array(amplitudes.T)[0])
        plt.ylim((-1.1,1.1))
        plt.xticks(x)
        y = 0.1
        for i in range(self.n_of_states):
            label = "$|{:03b}>$".format(i)
            x = i - 0.15
            if amplitudes[i] >= 0:
                plt.text(x, -y, label)
            else:
                plt.text(x, y, label)
        plt.grid(True,axis="y",linestyle='dotted')
        plt.title(title)
        plt.ylabel("Amplitude")
        plt.xlabel("States")
        plt.show()

    def initialize_wave_function(self):
        self.wave_function = np.matrix(np.zeros((self.n_of_states,1)))
        self.wave_function[0] = 1
        self.print_matrix(self.wave_function)
        self.print_wave_function()

    def H(self):
        self._print_to_jupyter(r"|\psi\rangle_{t+1} = %s |\psi\rangle_t"%("H"))
        self.apply_function(self.hadamard) 

    def X(self):
        self._print_to_jupyter(r"|\psi\rangle_{t+1} = %s |\psi\rangle_t"%("X"))
        self.apply_function(self.x) 

    def Z(self):
        self._print_to_jupyter(r"|\psi\rangle_{t+1} = %s |\psi\rangle_t"%("Z"))
        self.apply_function(self.z) 

    def C(self,matrix, name:str,order : int = 0):
        if order == 0:
            order = self.n_of_qbits

        for _ in range(order - 1):
            matrix = self.control_operator(matrix)
        
        self._print_to_jupyter(r"|\psi\rangle_{t+1} = %s |\psi\rangle_t"%(name+"^"+str(order)))
        self.apply_function(matrix) 

    def CX(self,order = 0):
        self.C(self.base_x,"CX",order)

    def CZ(self,order = 0):
        self.C(self.base_z,"CZ",order)


    def apply_function(self, matrix, name : str = None):
        if name and self._print:
            self._print_to_jupyter(r"|\psi\rangle_{t+1} = %s |\psi\rangle_t"%name)
        result = matrix * self.wave_function
        if self._print:
            self._print_step(matrix,self.wave_function,result)
        self.wave_function = result
        if self._print:
            self.print_wave_function()

    def tensor_product(self, matrix1, matrix2):
        x1, y1 = matrix1.shape
        x2, y2 = matrix2.shape
        x = x1 * x2
        y = y1 * y2
        result = np.zeros((x,y))
        for _x in range(x1):
            for _y in range(y1):
                result[_x*x2:(_x+1)*x2,_y*y2:(_y+1)*y2] = matrix1[_x,_y] * matrix2
        return result