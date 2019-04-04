using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace MFA
{
    class Driver
    {
        static int howManyRuns()// all functions here must be static. Otherwise create a new class and instantiate it in the static method
        {
            System.Console.WriteLine("Write how many runs you want the quantum program to do (default=1)");
            String input=Console.ReadLine();
            int nIteration=1000;
            if(Int32.TryParse(input,out nIteration))
                return nIteration;
            else
                return 1;
        }

        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: false))//It seems that Qubits should be released with Zero state
            {
                int nIteration = Driver.howManyRuns();
                Double[] avg={0,0,0,0,0,0,0,0,0,0};
                const int numberOfVertices=3;
                const int numberOfEdges=4;
                QArray<long> startArc=  new QArray<long>(0,0,1,2);//0->1 arc, 0->2 arc, 1->2 arc, 2->1 arc
                QArray<long> endArc=    new QArray<long>(1,2,2,1);
                for (int i = 0; i < nIteration; i++)
                {
                    var rawResult = QMain.Run(qsim,numberOfVertices,startArc,endArc,numberOfEdges).Result;
                    var resultArray=rawResult.ToArray();
                    for(int j=0;j<numberOfEdges;++j)
                    {
                        avg[j]+=resultArray[j]==Result.One?1:0;
                    }
                }
                for (int i = 0; i < numberOfEdges; i++)
                {
                    avg[i]=avg[i]/nIteration;
                    System.Console.WriteLine($"Arc {startArc[i]}->{endArc[i]}  QBit {i} have been taken {avg[i]*100}% of times");
                }
            }

            System.Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}