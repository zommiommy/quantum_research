namespace MFA
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Math;

    operation initializeQBitValue (desiredValue : Result, qBit : Qubit) : Unit {//Unit is almost equal to void in C#
        if (desiredValue != Zero)//they are all initialized to Zero
        {
            X(qBit);
        }

    }

    operation bEntangle(qBit1 : Qubit,qBit2 : Qubit): Unit
    {
        H(qBit1);
        CNOT(qBit1,qBit2);//Control qbit is at hadamard 
        H(qBit1);
    }
//Per avvicinarmi all'obiettivo, devo poter partire da uno stato iniziale Q0,Q1 e arrivare con egual probabilità allo stato |11> oppure |00>
//Logica del : prarcEndi tutti e 2 oppure lascia entrambi
    operation QMain(numberOfVertices: Int,edgesPairS:Int[],edgesPairD:Int[],numberOfEdges: Int) : (Result[])   // Q# uses tuples as a way to pass multiple values, rather than using structures or records.
    {
        //mutable= Variable, let= Constant number of qubits to be used - 1
        
        mutable returnval=new Result[numberOfEdges];//there was a +1 here
        
            using(edge=Qubit[numberOfEdges])//Only way to allocate Qubits for a specified codeblock
            {
                let source=0;
                let sink=numberOfVertices-1;
                for(i in 0..numberOfEdges-1)
                {
                    initializeQBitValue(Zero,edge[i]);
                    let arcStart=edgesPairS[i];
                    let arcEnd=edgesPairD[i];
                    if (arcStart == source && arcEnd== sink)
                    {
                    initializeQBitValue(One, edge[i]);
                    }
                    else {
                        if (arcStart == source || arcEnd== sink)
                        {
                            Rx(PI()/2.0,edge[i]);
                        }
                    }
                }
                

                //The idea i want to apply is to entangle all couples of consecutive edges with eachothers
                // such that both the consecutive edges would be taken or not
                //I don't think it will work, but at least i'll try it
                //not automated attempt
                for(k in 1..1)
                {
                    for(i in 0..numberOfEdges-1)
                    {
                    //    H(edge[i]);
                    }
                    bEntangle(edge[0],edge[2]);//edge 0 is antecedent of edge 2
                    bEntangle(edge[3],edge[2]);
                    //H(edge[1]);

                    for(i in 0..numberOfEdges-1)
                    {
                        //H(edge[i]);
                    }
                }

                //
                //MEASUREMENT
                //
                for(i in 0..numberOfEdges-1)
                {
                set returnval[i]=M(edge[i]);
                }
            }
        
        return returnval;//returns must be outside "using" codeblocks
    }
}
