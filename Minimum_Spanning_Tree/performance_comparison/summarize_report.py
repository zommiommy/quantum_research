import os
import re
import json

lista = []
for file in os.listdir("./reports/"):
    qbits, shots = re.findall("report(\d+)_(\d+)", file)[0]
    with open("./reports/"+file, "r") as f:
        txt = f.read()
    U_time = re.findall("User time \(seconds\): (\d+\.?\d*)", txt)
    S_time = re.findall("System time \(seconds\): (\d+\.?\d*)", txt)
    mem = re.findall("Maximum resident set size \(kbytes\): (\d+\.?\d*)", txt)
    mem = [int(x) for x in mem]
    time = [float(x) + float(y) for x, y in zip(U_time, S_time)]
    value = {
        "qbits":int(qbits),
        "shots":int(shots),
    }
    for i, name in enumerate(["cirq", "qsharp", "qiskit", "qiskit_opt"]):
        value.update({name:{"time":time[i], "mem":mem[i]}})
    lista.append(value)

with open("report_summary.json","w") as f:
    json.dump(lista, f)