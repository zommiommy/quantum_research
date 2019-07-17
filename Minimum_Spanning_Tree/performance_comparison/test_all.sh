#!/bin/bash
printf "#############################################################################################\n"
printf "New Batch\n"
printf "#############################################################################################\n"

printf "Test Description:\n"
printf "\tTest of the 3 freamwork executing the Grover search of a single number\n"
printf "\tWith $1 searchable qbits and $2 repetitions\n"

printf "\nSystem specifications\n"
neofetch --off --color_blocks off --stdout

printf "\nTesting cirq runtine\n"
/usr/bin/time  --verbose python scripts/cirq/grover_cirq.py $1 $2 > /dev/null 

cd scripts/qsharp
# Call the script once before time it so that we don't measure the building
printf "\nTesting Q# runtime\n"
/usr/bin/time  --verbose dotnet run  $1 $2 > /dev/null
cd ../..

printf "\nTesting qiskit runtime without optimizations\n"
/usr/bin/time  --verbose python scripts/qiskit/grover_qiskit.py  $1 $2 > /dev/null

printf "\nTesting qiskit runtime with optimizations\n"
/usr/bin/time  --verbose python scripts/qiskit/grover_qiskit_with_optimizations.py  $1 $2 > /dev/null
