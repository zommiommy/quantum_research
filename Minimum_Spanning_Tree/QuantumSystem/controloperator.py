
import numpy as np

def control_operator(matrix):
    x1, y1  = matrix.shape
    x, y = 2*x1, 2* y1
    result = np.eye(x,dtype=np.complex)
    result[-x1:,-y1:] = matrix
    return result