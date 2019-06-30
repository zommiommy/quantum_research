#!/bin/bash
echo "Testing qiskit runtime"
time python scripts/qiskit/qiskit.py

echo "Testing cirq runtine"
time python scripts/cirq/cirq.py

echo "Testing Q# runtime"
cd scripts/qsharp
time dotnet run
cd ../..
