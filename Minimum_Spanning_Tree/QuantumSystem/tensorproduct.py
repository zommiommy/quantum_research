
import numpy as np

def tensor_product(matrix1, matrix2):
    x1, y1 = matrix1.shape
    x2, y2 = matrix2.shape
    x = x1 * x2
    y = y1 * y2
    result = np.zeros((x,y),dtype=np.complex)
    for _x in range(x1):
        for _y in range(y1):
            result[_x*x2:(_x+1)*x2,_y*y2:(_y+1)*y2] = matrix1[_x,_y] * matrix2
    return result