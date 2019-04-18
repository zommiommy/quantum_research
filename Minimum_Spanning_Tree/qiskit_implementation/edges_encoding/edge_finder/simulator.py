

import json
import socket
import qiskit as q
from math import ceil
from typing import Dict, Tuple, List
from multiprocessing import Process, Queue
from qiskit import QuantumCircuit
from .timeit import time_function
from .get_logger import get_logger

logger = get_logger(__name__)

def rotate_string(value : int) -> int:
    return int("".join(list(reversed("{:013b}".format(value)))), base=2)

def simulation_client(host : str, port : int, circuit : QuantumCircuit, n_of_shots : int, n_of_threads : int, result_queue : Queue, ipv4 : bool = False):
    command = {"n_of_shots":n_of_shots, "n_of_threads":n_of_threads, "qasm":circuit.qasm()}

    logger.info("Going to connect to {} : {}".format(host, port))

    if ipv4:
        s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        s.connect((host, port))
    else:
        s = socket.socket(socket.AF_INET6, socket.SOCK_STREAM)
        s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        s.connect((host, port, 0, 0))

    logger.info("Dispatching simulation of {} shots for {} threads to {} : {}".format(n_of_shots, n_of_threads, host, port))

    s.send((json.dumps(command) + "\n").encode())
    
    data = b""
    while b"\n" not in data:
        data += s.recv(1024)
        
    logger.info("Received results from {} : {}".format(host, port))
    results = json.loads(data.decode())

    logger.info("Closing connection to {} : {}".format(host, port))
    s.close()

    result_queue.put(results["results"])

def simulation_worker(port : int , ipv4 : bool = False) -> None:

    logger.info("Starting the Simulation Worker on port {}".format(port))
    simulator = Simulator()
    
    if ipv4:
        s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    else:
        s = socket.socket(socket.AF_INET6, socket.SOCK_STREAM)

    s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)

    s.bind(("", port,))
    s.listen(1)
    logger.info("Listening for connections")
    
    while True:
        conn, addr = s.accept()
        logger.info("Accepted connection from {} {}".format(*addr))

        data = b""
        while b"\n" not in data:
            data += conn.recv(1024)
            
        data = json.loads(data.decode())

        n_of_shots = data["n_of_shots"]
        n_of_threads = data["n_of_threads"]
        logger.info("Starting {} execution on {} threads".format(n_of_shots, n_of_threads))
        qasm = data["qasm"]
        
        results = simulator.parallel_simulation(q.QuantumCircuit.from_qasm_str(qasm), n_of_shots, n_of_threads)

        conn.send((json.dumps({"results":results}) + "\n").encode())

        logger.info("Done! Now closing the connection.")
        conn.close()

class Simulator():

    def __init__(self):
        self.results = {}

    @time_function
    def simulate(self, circuit : QuantumCircuit, n_of_shots : int) -> Dict[str,int]:
        logger.info("Starting simulation.")
        # Initialize the BackEnd
        backend_sim = q.BasicAer.get_backend('qasm_simulator')

        qobj = q.compile(circuit, backend_sim, shots=n_of_shots)

        self.results = backend_sim.run(qobj).result().get_counts(circuit)

        return self.results

    @time_function
    def parallel_simulation(self, circuit : QuantumCircuit, n_of_shots : int , n_of_threads : int = 4) -> Dict[str,int]:
        logger.info("Starting parallel simulation.")

        backend = q.Aer.get_backend("qasm_simulator")

        job_shots = int(n_of_shots / n_of_threads)

        compiled_circuit = q.compile(circuit, backend, shots=job_shots)

        qobj_list = [compiled_circuit] * n_of_threads

        logger.info("Starting %d simulation threads."%n_of_threads)

        job_list = [backend.run(qobj) for qobj in qobj_list]

        self.results = {}

        while job_list:
            for job in job_list:
                if job.status() == q.providers.JobStatus.DONE:
                    logger.info("A thread finished.")
                    job_list.remove(job)
                    for key, item in job.result().get_counts().items():
                        self.results[key] = self.results.get(key, 0) + item

        return self.results

    @time_function
    def distribuited_simulation(self, circuit : QuantumCircuit, n_of_shots : int , workers : List[Tuple[str,str,int,bool]]) -> Dict[str,int]:

        total_threads = sum((x[2] for x in workers))

        logger.info("Total threads: %d"%total_threads)

        shots_per_thread = ceil(n_of_shots / total_threads)

        queue = Queue()

        self.results = {}

        processes = [Process(target=simulation_client, args=(host, port, circuit, shots_per_thread * threads, threads, queue,ip_type)) for host, port, threads, ip_type in workers]

        for process in processes:
            process.start()

        for process in processes:
            process.join()

        while not queue.empty():
            result = queue.get()
            for key, item in result.items():
                self.results[key] = self.results.get(key, 0) + item

        return self.results
        
    def save_results(self, filepath : str = "results.json") -> None:
        logger.info("Saving the results to %s"%filepath)
        with open(filepath,"w") as f:
            json.dump(self.results, f,indent=4)



    @time_function
    def symbolic_simulation(self, circuit : QuantumCircuit, threshold : float = 1e-6) -> List[str]:
        """Calculate the final wave-function."""
        backend_sim = q.BasicAer.get_backend('statevector_simulator')
        result = q.execute(circuit, backend_sim, shots=1).result()

        logger.info("Printing the states with probability >= %f:"%threshold)

        state_list = [(index, value, abs(value)**2) for index, value in enumerate(result.get_statevector(circuit))]

        state_list.sort(key=lambda x: x[1].real, reverse=True)

        format_encode = "{:0" + str(circuit.width()) + "b}"

        results = []

        for index, value, probability in state_list:
            if probability > threshold:
                encoding = format_encode.format(index)[::-1]
                output = "\t P: {:.4}\t".format(probability)
                index = 0
                for register in circuit.qregs[:-1]:
                    new_index = index + register.size
                    output += "|" + encoding[index:new_index][::-1] + ">"
                    index = new_index
                output += "{:.5}".format(value)
                logger.info(output)
                results.append(output)
        
        return results