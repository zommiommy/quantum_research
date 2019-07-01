#!/bin/bash
echo "System specifications"
neofetch

echo "Testing cirq runtine"
/usr/bin/time  --verbose python scripts/cirq/grover_cirq.py > /dev/null

cd scripts/qsharp
# Call the script once before time it so that we don't measure the building
echo "Building Q# runtime"
/usr/bin/time  --verbose dotnet run > /dev/null
echo "Testing Q# runtime"
/usr/bin/time  --verbose dotnet run > /dev/null
cd ../..

echo "Testing qiskit runtime without optimizations"
/usr/bin/time  --verbose python scripts/qiskit/grover_qiskit.py > /dev/null

echo "Testing qiskit runtime with optimizations"
/usr/bin/time  --verbose python scripts/qiskit/grover_qiskit_with_optimizations.py > /dev/null
