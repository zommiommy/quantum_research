
import matplotlib
from matplotlib import rc
import matplotlib.pyplot as plt

import numpy as np

class Printer():

    def __init__(self, n_of_qbits):
        self.set_latex_font()
        self.set_grid_below_graph()
        self.n_of_qbits = n_of_qbits
        self.n_of_states = 2**n_of_qbits

    def set_grid_below_graph(self):
        plt.rc('axes', axisbelow=True)

    def set_latex_font(self):
        matplotlib.rcParams['mathtext.fontset'] = 'stix'
        matplotlib.rcParams['font.family'] = 'STIXGeneral'
        rc('font',**{
            'size': 13
            })

    def print_wave(self, amplitudes, title: str):
        x = np.arange(self.n_of_states)
        plt.figure(figsize=(15,5))

        for i, v in enumerate(np.array(amplitudes.T)[0]):
            label = r"$|{:03b}\rangle$".format(i)
            plt.arrow(i, 0, np.imag(v), np.real(v), head_width=0.03, head_length=0.03, color="b")
            y = -0.1
            if np.real(v) < 0:
                y = 0.05
            plt.text(i - 0.15,y , label)

        plt.ylim((-1.1,1.1))
        plt.xlim((-1.1, self.n_of_states + 0.1))
        plt.xticks(x)
        plt.grid(True,linestyle='dotted')
        plt.title(title)
        plt.ylabel(r"$\operatorname{Re}$")
        plt.xlabel(r"$\operatorname{Im}$")
        plt.show()

    def print_probabilities(self, porbabilities, title : str):
        x = np.arange(self.n_of_states)
        plt.figure(figsize=(15,3))
        plt.bar(x,np.array(porbabilities.T)[0])
        plt.ylim((-0.1,1.1))
        plt.xticks(x,labels = [r"$|{:03b}\rangle$".format(i) for i in x])
        plt.grid(True,axis="y",linestyle='dotted')
        plt.title(title)
        plt.ylabel("Probability")
        plt.xlabel("States")
        plt.show()