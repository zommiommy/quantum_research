import numpy as np
import matplotlib.pyplot as plt
from IPython.display import display, Math

class QuantumSystem():
    base_hadamard = np.matrix([[1,1],[1,-1]]).astype(np.complex)
    base_x = np.matrix([[0,1],[1,0]]).astype(np.complex)
    base_y = np.matrix([[0,-1j],[1j,0]]).astype(np.complex)
    base_z = np.matrix([[1,0],[0,-1]]).astype(np.complex)

    def __init__(self):
        self._print = True
        self.counter = 0


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
        result = np.eye(x,dtype=np.complex)
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

    def print_wave_function(self):
        self._print_graph(self.wave_function, """Wave_function $\psi_{%d}$"""%self.counter)
        self._print_probabilities(self.wave_function, """Probability distribution of $\psi_{%d}$"""%self.counter )

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

    def print_matrix(self, matrix, intro = None):
        if intro:
            intro = intro
        else:
            intro = r"|\psi_{%d}\rangle = "%self.counter
        output = intro +  self._latex_rappresentation(matrix)
        self._print_to_jupyter(output)

    def _print_step(self, matrix, vector, result, intro : str = ""):
        string = intro
        string += self._latex_rappresentation(matrix)
        string += self._latex_rappresentation(vector)
        string += " = "
        string += self._latex_rappresentation(result)
        self._print_to_jupyter(string)


    def _print_graph(self, amplitudes, title: str):
        x = np.arange(self.n_of_states)
        plt.figure(figsize=(15,5))

        for i, v in enumerate(np.array(amplitudes.T)[0]):
            label = "$|{:03b}>$".format(i)
            plt.arrow(i, 0, np.imag(v), np.real(v), head_width=0.03, head_length=0.03, color="b")
            b = -0.1 * np.exp(1j * np.angle(v))
            plt.text(np.imag(b) + i - 0.15,np.real(b), label)

        plt.ylim((-1,1.1))
        plt.xlim((-0.5,self.n_of_states - 0.5))
        plt.xticks(x)
        plt.grid(True,axis="y",linestyle='dotted')
        plt.title(title)
        plt.ylabel(r"$\operatorname{Re}$")
        plt.xlabel(r"$\operatorname{Im}$")
        plt.show()

    def _print_probabilities(self, amplitudes, title : str):
        amplitudes = self.get_probabilities(amplitudes)
        x = np.arange(self.n_of_states)
        plt.figure(figsize=(15,3))
        plt.bar(x,np.array(amplitudes.T)[0])
        plt.ylim((-0.1,1.1))
        plt.xticks(x)
        for i in range(self.n_of_states):
            label = "$|{:03b}>$".format(i)
            plt.text(i - 0.15, -0.075, label)
        plt.grid(True,axis="y",linestyle='dotted')
        plt.title(title)
        plt.ylabel("Probability")
        plt.xlabel("States")
        plt.show()

    def initialize_wave_function(self):
        self.wave_function = np.matrix(np.zeros((self.n_of_states,1),dtype=np.complex))
        self.wave_function[0] = 1
        self.print_matrix(self.wave_function)
        self.print_wave_function()

    def H(self):
        # Normalize the hadamard gate
        self.apply_function(self.hadamard, name = "H", coeff= 1 / ((self.n_of_states)**0.5), intro=r"\frac{1}{\sqrt{%d}}"%self.n_of_states) 

    def X(self):
        self.apply_function(self.x, name = "X") 

    def Z(self):
        self.apply_function(self.z, name = "Z") 

    def C(self,matrix, name:str,order : int = 0):
        if order == 0:
            order = self.n_of_qbits

        for _ in range(order - 1):
            matrix = self.control_operator(matrix)
        
        self.apply_function(matrix, name= "C" * (order - 1) + name) 

    def CX(self,order = 0):
        self.C(self.base_x,name="CX",order=order)

    def CZ(self,order = 0):
        self.C(self.base_z,name="CZ",order=order)

    def get_probabilities(self, wave_function):
        return np.square(wave_function)
        # return (wave_function * np.conjugate(wave_function.T)).diagonal()

    def apply_function(self, matrix, name : str = None, coeff : complex = 1, intro : str = ""):
        if name:
            self._print_to_jupyter(r"|\psi_{%d}\rangle = %s |\psi_{%d}\rangle"%(self.counter+1,name,self.counter))
        result = coeff * matrix * self.wave_function
        if self._print:
            self._print_step(matrix,self.wave_function,result,intro=intro)
        self.wave_function = result
        if self._print:
            self.print_wave_function()
        self.counter += 1

    def tensor_product(self, matrix1, matrix2):
        x1, y1 = matrix1.shape
        x2, y2 = matrix2.shape
        x = x1 * x2
        y = y1 * y2
        result = np.zeros((x,y),dtype=np.complex)
        for _x in range(x1):
            for _y in range(y1):
                result[_x*x2:(_x+1)*x2,_y*y2:(_y+1)*y2] = matrix1[_x,_y] * matrix2
        return result