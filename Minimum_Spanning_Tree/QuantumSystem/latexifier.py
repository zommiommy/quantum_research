
import numpy as np
from IPython.display import display, Math, Latex, Markdown

def latex_rappresentation(matrix):
    output = r"\displaystyle\begin{pmatrix}"
    for row in matrix:
        for value in np.array(row).reshape(row.size):
            # Special cases to have nicer formatting
            if np.imag(value) == 0:
                value = np.real(value)
            if np.imag(value) == 1 and np.real(value) == 0:
                output += "j"
            elif np.imag(value) == -1 and np.real(value) == 0:
                output += "-j"
            elif np.real(value) == 1 and np.imag(value) == 0:
                output += "1"
            elif np.real(value) == -1 and np.imag(value) == 0:
                output += "-1"
            elif np.real(value) == 0 and np.imag(value) == 0:
                output += "0"
            else:
                output += str(round(value,3))
            output += " & "
        # Cancell the excessive &
        output = output[:-2]
        output += r"\\"
    # Cancell the excessive \\
    output = output[:-2]
    output += r"\end{pmatrix}"
    return output

def mdprint(string):
    display(Markdown(string))

def print_to_jupyter(string):
    display(Latex(r"" + string + r""))

def mathify(string):
    return r"\[" + string + r"\]"

def print_matrix(matrix, intro = ""):
    output = intro +  latex_rappresentation(matrix)
    print_to_jupyter(mathify(output))

def print_operator(matrix, vector, result, intro : str = ""):
    string = r"\begin{eqnarray}"
    string += intro
    string += latex_rappresentation(matrix)
    string += latex_rappresentation(vector)
    string += " = "
    string += latex_rappresentation(result)
    string += r"\end{eqnarray}"
    print_to_jupyter(mathify(string))


