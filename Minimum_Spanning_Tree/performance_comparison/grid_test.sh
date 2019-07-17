#!/bin/bash
# Call the script once before time it so that we don't measure the building
cd scripts/qsharp
dotnet run 5 1 > /dev/null
cd ../..

for I in {1..5}
do
    for N_OF_QBITS in {5..10}
    do
        SHOTS=$(python -c "print(10 ** $I)")
        FILENAME="report"
        FILENAME+=$(printf "%02d" $N_OF_QBITS)
        FILENAME+="_"
        FILENAME+=$SHOTS 
        echo $FILENAME
        bash test_all.sh $N_OF_QBITS $SHOTS > reports/$FILENAME 2>&1
    done
done