using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace MFA
{
    class Driver
    {
        static int howManyRuns()// all functions here must be static. Otherwise create a new class and instantiate it in the static method
        {
            System.Console.WriteLine("Write how many runs you want the quantum program to do (default=100)");
            String input=Console.ReadLine();
            int nIteration=1000;
            if(Int32.TryParse(input,out nIteration))
                return nIteration;
            else
                return 100;
        }

        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: false))//It seems that Qubits should be released with Zero state
            {
                int nIteration = Driver.howManyRuns();
                System.Console.WriteLine($"nIteration = {nIteration}");
                Double[] avg={0,0,0,0,0,0,0,0,0,0};
                const int numberOfVertices=3;
                const int numberOfEdges=3;

                for (int i = 0; i < nIteration; i++)
                {
                    QArray<long> arr1=new QArray<long>(0,0,1);
                    
                    var rawResult = QMain.Run(qsim,numberOfVertices,arr1,new QArray<long>(1,2,2),numberOfEdges).Result;
                    var resultArray=rawResult.ToArray();
                    for(int j=0;j<numberOfEdges;++j)
                    {
                        avg[j]+=resultArray[j]==Result.One?1:0;
                        System.Console.WriteLine($"resultArray[{j}] = {resultArray[j]}");
                    }
                }
                for (int i = 0; i < numberOfEdges; i++)
                {
                    avg[i]=avg[i]/nIteration;
                    System.Console.WriteLine($"QBit {i}:"+$" {avg[i]*100}% of One");
                }
            }

            System.Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}