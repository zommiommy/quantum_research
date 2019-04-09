namespace MFA
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;

    operation initializeQBitValue (desiredValue : Result, qBit : Qubit) : Unit {//Unit is almost equal to void in C#
        if (desiredValue != Zero)//they are all initialized to Zero
        {
            X(qBit);
        }
        //standard version measures them in order to obtain what they need.
        // I find that a bit superfluous if i use this function only to initialize data.
    }

    operation initializeQBitArray (desiredValues : Bool[], qBits : Qubit[]) : Unit {//Unit is almost equal to void in C#
        let qBitsSize=Length(qBits);
        let desiredValuesSize=Length(desiredValues);
        //debug code
        //mutable mystr="[";
        //for (i in desiredValues){set mystr= mystr+ToStringB(i)+" ";}
        //Message("desired values: "+mystr+"]");
        //end debug

        if(qBitsSize==1)
        {
            
            if (desiredValues[0] != false)//they are all initialized to Zero
            {
                X(qBits[0]);
            }
            else
            {}
        }
        else
        {
        for (i in 0..qBitsSize-1)
        {
            if (desiredValues[i] != false)//they are all initialized to Zero
            //if it crashes here, it means that there is a mismatch between the conversion from BigInt to Bool array
            //Usually, an  8 bit array is provided
            {
                X(qBits[i]);
            }
            else{}
        }
        }
        //standard version measures them in order to obtain what they need.
        // I find that a bit superfluous if i use this function only to initialize data.
    }

    operation oneHot2(qb0:Qubit,qb1:Qubit):Unit
    {
        H(qb0);
	    X(qb1);
        CNOT(qb0,qb1);
        //supposing initial state was |00>, we obtain
       //50%|01> 50%|10> without using extra qbits
    }
    operation oneHot(qb: Qubit[]):Unit
    {
        //eg for Length(qb)=4, first iteration uses an initialization of the extra qbits Q0 & Q1 like:
                //Q0 H
                //Q1 H 
            //2nd:
                //Q0 H X
                //Q1 H
            //3rd:
                //Q0 H
                //Q1 H X
            //4rt:
                //Q0 H X
                //Q1 H X
        let qbSize=Length(qb);
        let howManyExtraQubits=Ceiling(Log(ToDouble(qbSize))/Log(2.0));//base 2 logarithm
        
        using(extra=Qubit[howManyExtraQubits])
        {
            for (e in extra)
            {
            H(e);
            }
            for(i in 0..qbSize-1)//for each qbit to be controlled
            {
                let boolArr=BigIntToBools(ToBigInt(i));//Converted to an 8 bit bool array!
                initializeQBitArray(boolArr,extra);
                Controlled X(extra, qb[i]);//controls the Qbit
                initializeQBitArray(boolArr,extra);//now it undoes the circuit, so that it will be cleaned
                
                //I could use Gray encoding for counting which could save some gates (unitary hamming distance)
                //Maybe i'll do it another time
            }
            for (e in extra)//resetting the qbits
            {
            H(e);
            }
        }
    }
//Per avvicinarmi all'obiettivo, devo poter partire da uno stato iniziale Q0,Q1 e arrivare con egual probabilità allo stato |11> oppure |00>
//Logica del : prendi tutto un percorso oppure lascia entrambi
    operation QMain(numberOfVertices: Int,edgesPairS:Int[],edgesPairD:Int[],howManyArcsFromSource : Int, howManyArcsToSink : Int) : (Result[])   // Q# uses tuples as a way to pass multiple values, rather than using structures or records.
    {
        let numberOfEdges=Length(edgesPairS);
        //mutable= Variable, let= Constant 
        
            using(edge=Qubit[numberOfEdges])//Only way to allocate Qubits for a specified codeblock
            {
                let source=0;
                let sink=numberOfVertices-1;
                mutable sourceSet=edge[0..howManyArcsFromSource-1];
                mutable sinkSet=edge[howManyArcsToSink-1..numberOfEdges-1];
                for(i in 0..numberOfEdges-1)
                {
                    initializeQBitValue(Zero,edge[i]);
                    let arcStart=edgesPairS[i];
                    let arcEnd=edgesPairD[i];
                    if (arcStart == source and arcEnd== sink)
                    {//to be chosen for sure
                    }
                }

                //The idea i want to apply is to entangle all couples of consecutive edges with eachothers
                // such that both the consecutive edges would be taken or not
                //I don't think it will work, but at least i'll try it
                oneHot(sourceSet);
                //
                oneHot(sinkSet);
                //MEASUREMENT
                //
                return MultiM(edge);//returns must be outside "using" codeblocks
                //UPDATE: since last version is no more required
            }
    }
}
