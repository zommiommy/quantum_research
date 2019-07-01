#!/bin/bash
printf "Test Description:\n"
printf "\tTest of the 3 freamwork executing the Grover search of a single number\n"
printf "\tWith 10 searchable qbits and 10000 repetitions\n"

printf "\nSystem specifications\n"
neofetch

printf "\nTesting cirq runtine\n"
/usr/bin/time  --verbose python scripts/cirq/grover_cirq.py > /dev/null

cd scripts/qsharp
# Call the script once before time it so that we don't measure the building
printf "\nTesting Q# build & runtime\n"
/usr/bin/time  --verbose dotnet run > /dev/null
printf "\nTesting Q# runtime only\n"
/usr/bin/time  --verbose dotnet run > /dev/null
cd ../..

printf "\nTesting qiskit runtime without optimizations\n"
/usr/bin/time  --verbose python scripts/qiskit/grover_qiskit.py > /dev/null

printf "\nTesting qiskit runtime with optimizations\n"
/usr/bin/time  --verbose python scripts/qiskit/grover_qiskit_with_optimizations.py > /dev/null
