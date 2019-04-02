namespace MFA
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation setQBitValue (desiredValue : Result, qBit : Qubit) : Unit {//Unit is almost equal to void in C#
        if (desiredValue != Zero)//they are all initialized to Zero
        {
            X(qBit);
        }

    }
//Per avvicinarmi all'obiettivo, devo poter partire da uno stato iniziale Q0,Q1 e arrivare con egual probabilità allo stato |11> oppure |00>
//Logica del : prendi tutti e 2 oppure lascia entrambi
    operation QMain(numberOfVertices: Int,edgesPairS:Int[],edgesPairD:Int[],numberOfEdges: Int) : (Result[])   // Q# uses tuples as a way to pass multiple values, rather than using structures or records.
    {
        //mutable= Variable, let= Constant number of qubits to be used - 1
        
        mutable returnval=new Result[numberOfVertices];//there was a +1 here
        
            using(edges=Qubit[numberOfEdges])//Only way to allocate Qubits for a specified codeblock
            {

                let source=0;
                let sink=numberOfVertices-1;
                //for(i in 0..numberOfVertices-1)
                //{
                //setQBitValue(Zero,vertices[i]);// One and Zero are reserved words
                //}
                for(i in 0..numberOfEdges-1)
                {
                setQBitValue(Zero,edges[i]);
                H(edges[i]);
                let start=edgesPairS[i];
                let end=edgesPairD[i];
                }

                for(i in 0..numberOfEdges-1)
                {
                set returnval[i]=M(edges[i]);
                }
            }
        
        return returnval;//returns must be outside "using" codeblocks
    }
}
