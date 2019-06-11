import qiskit as q
X = q.QuantumRegister(3, "x")
J = q.QuantumRegister(3, "j")
A = q.QuantumRegister(10, "a")
c = q.QuantumCircuit(X, J, A)

# A0 = (X0 == J0)
c.cx(X[0], A[0])
c.cx(J[0], A[0])
# A1 = (X0 > J0)
c.x(X[0])
c.ccx(X[0], J[0], A[1])

# A2 = (X1 == J1)
c.cx(X[1], A[2])
c.cx(J[1], A[2])
# A3 = (X1 > J1)
c.x(X[1])
c.ccx(X[1], J[1], A[3])

# A4 = (X1 > J1)
c.x(X[2])
c.ccx(X[2], J[2], A[4])

# A5 = A1 && A3
c.ccx(A[1], A[3], A[5])

# A6 = A1 && A2
c.ccx(A[1], A[2], A[6])
# A7 = A6 && A4
c.ccx(A[6], A[4], A[7])

# A8 = A1 || A5
c.x(A[1])
c.x(A[5])
c.x(A[8])
c.ccx(A[1], A[5], A[8])


# A9 = A8 || A7
c.x(A[7])
c.x(A[8])

# Part to not reverse
c.x(A[9])
c.ccx(A[7], A[8], A[9])

# REVERSE
c.x(A[8])
c.x(A[7])
c.ccx(A[1], A[5], A[8])
c.x(A[8])
c.x(A[5])
c.x(A[1])
c.ccx(A[6], A[4], A[7])
c.ccx(A[1], A[2], A[6])
c.ccx(A[1], A[3], A[5])
c.ccx(X[2], J[2], A[4])
c.x(X[2])
c.ccx(X[1], J[1], A[3])
c.x(X[1])
c.cx(J[1], A[2])
c.cx(X[1], A[2])
c.ccx(X[0], J[0], A[1])
c.x(X[0])
c.cx(J[0], A[0])
c.cx(X[0], A[0])

print(c.draw(output="latex_source"))