import qiskit as q
import qiskit_aqua

from math import floor, pi, sqrt


# Inizzializzazione dei qbit e i bit su cui fare la ricerca
register = q.QuantumRegister(8, name="values")
# Lista dei singoli qbits per averne accesso piu' agevole
qbits = [q for q in register]
# Inizzalizzazione degli ancilla qbits che saranno necessari per il cnx gate
ancillas = q.QuantumRegister(8, name="ancillas")

# Creazione del circuito quantum
circuit = q.QuantumCircuit(register, ancillas)
# Mettiamo in superposizione i qbits
circuit.h(qbits)


# Costruiamo un oracolo d'esempio che cerca il valore 1010 0101
oracle = q.QuantumCircuit(register, ancillas)
# Poniamo un gate X in corrispondenza dei bit uguali a 0 nel valore cercato
oracle.x(qbits[1])
oracle.x(qbits[3])
oracle.x(qbits[4])
oracle.x(qbits[6])

# costuriamo un (c^n Z) per poter selezionare il valore
# poiche' su qiskit non e' presente sfruttiamo che HXH = Z
oracle.h(qbits[-1])
oracle.cnx(qbits[:-1], qbits[-1], ancillas)
oracle.h(qbits[-1])

# Rimettiamo a posto lo stato dei qbits rieseguendo le operazioni al contrario
oracle.x(qbits[6])
oracle.x(qbits[4])
oracle.x(qbits[3])
oracle.x(qbits[1])


def construct_diffusion_operator(registers, qbits, ancillas) -> q.QuantumCircuit:
    """Create the diffusion circuit for the registers."""
    diffusion = q.QuantumCircuit(*registers, ancillas)

    # Creiamo un muro di H e X
    for qbit in qbits:
        circuit.h(qbit)
        circuit.x(qbit)

    # Poiche' non esiste il C^n Z su qiskit sfruttiamo ancora HXH = Z
    diffusion.h(qbits[-1])
    diffusion.cnx(qbits[:-1], qbits[-1],ancillas)
    diffusion.h(qbits[-1])

    # Secondo muro di X e H
    for qbit in qbits:
        diffusion.x(qbit)
        diffusion.h(qbit)

    return diffusion


def construct_grover(self, circuit : q.QuantumCircuit, oracle : q.QuantumCircuit, registers, qbits, ancillas, number_of_expected_results : int = 1) -> q.QuantumCircuit:
    """Create the circuit to perform a grover search given the orcale"""
    diffusion = construct_diffusion_operator(registers, qbits, ancillas)

    # Calcoliamo il numero di iterazioni previste
    number_of_iterations = (pi / 4)*sqrt((2**len(self.qbits)) / number_of_expected_results)
    # Arrotondiamo per difetto in quanto sperimentalemnte sembra dare i risultati migliori
    number_of_iterations = floor(number_of_iterations)

    # RIipetiamo oracolo e diffusione il numero calcolato di volte
    for _ in range(number_of_iterations):
        circuit += oracle
        circuit += diffusion

    return circuit

# Applichiamo grover
circuit = construct_grover(circuit, oracle, [register], qbits, ancillas)


# Setuppiamo il circuito per simularlo

# Inizzializziamo un registro di qbit classici
# I bit normali servono come registi dove il simulatore andra' a salvare il risultato dell'esperimento
cbits = q.ClassicalRegister(self.n_of_qbits, 'classical_values')

# Ed aggiungiamoli al circuito

circuit.add(cbits)
circuit.measure(register, cbits)

# Inizzializziamo il backend del simulatore
backend_sim = q.BasicAer.get_backend('qasm_simulator')

# Si compila il circuito per ottimizzarlo e renderlo eseguibile
# Ed imponiamo che il simulatore faccia 10^4 simulazioni
qobj = q.compile(circuit, backend_sim, shots=1e4)

# Otteniamo i risultati organizzati come frequenza degli stati misurati
results = backend_sim.run(qobj).result().get_counts(circuit)

# Stampiamo a schermo il risultato
print(results)
