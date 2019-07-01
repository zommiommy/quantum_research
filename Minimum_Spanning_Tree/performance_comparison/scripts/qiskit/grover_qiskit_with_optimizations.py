
import qiskit as q
import qiskit.aqua

from math import floor, pi, sqrt

# Inizzializzazione dei qbit e i bit su cui fare la ricerca
register = q.QuantumRegister(10, name="values")
# Lista dei singoli qbits per averne accesso piu' agevole
qbits = [q for q in register]
n_of_qbits = len(qbits)
# Inizzalizzazione degli ancilla qbits che saranno necessari per il cnx gate
ancillas = q.QuantumRegister(10, name="ancillas")

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
oracle.mcmt(qbits[:-1], ancillas, q.QuantumCircuit.cz, [qbits[-1]])

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
    oracle.mcmt(qbits[:-1], ancillas, q.QuantumCircuit.cz, [qbits[-1]])
    
    # Secondo muro di X e H
    for qbit in qbits:
        diffusion.x(qbit)
        diffusion.h(qbit)

    return diffusion


def construct_grover(circuit : q.QuantumCircuit, oracle : q.QuantumCircuit, registers, qbits, ancillas, number_of_expected_results : int = 1) -> q.QuantumCircuit:
    """Create the circuit to perform a grover search given the orcale"""
    diffusion = construct_diffusion_operator(registers, qbits, ancillas)

    # Calcoliamo il numero di iterazioni previste
    number_of_iterations = (pi / 4)*sqrt((2**len(qbits)) / number_of_expected_results)
    # Arrotondiamo per difetto in quanto sperimentalemnte sembra dare i risultati migliori
    number_of_iterations = floor(number_of_iterations)

    # RIipetiamo oracolo e diffusione il numero calcolato di volte
    for _ in range(number_of_iterations):
        circuit += oracle
        circuit += diffusion

    return circuit

# Applichiamo grover
circuit = construct_grover(circuit, oracle, [register], qbits, ancillas)

# Inizzializziamo il backend del simulatore
backend_sim = q.BasicAer.get_backend('qasm_simulator')
# Optimze the circuit
circuit = q.compiler.transpile(circuit, backend=backend_sim, optimization_level=2)

# Setuppiamo il circuito per simularlo

# Inizzializziamo un registro di qbit classici
# I bit normali servono come registi dove il simulatore andra' a salvare il risultato dell'esperimento
cbits = q.ClassicalRegister(n_of_qbits, 'classical_values')

# Ed aggiungiamoli al circuito

circuit.add_register(cbits)
circuit.measure(register, cbits)

# Si compila il circuito per ottimizzarlo e renderlo eseguibile
# Ed imponiamo che il simulatore faccia 10^4 simulazioni
qobj = q.compiler.assemble(circuit, shots=10000, seed_simulator=42)

# Otteniamo i risultati organizzati come frequenza degli stati misurati
results = backend_sim.run(qobj).result().get_counts(circuit)

# Stampiamo a schermo il risultato
print(results)