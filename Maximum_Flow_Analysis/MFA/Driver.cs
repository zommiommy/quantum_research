using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace MFA
{
    class Utilities
    {
        public int howManyRuns()// all functions here must be static. Otherwise create a new class and instantiate it in the static method
        {
            System.Console.WriteLine("Write how many runs you want the quantum program to do (default=1)");
            String input=Console.ReadLine();
            int nIteration=1000;
            if(Int32.TryParse(input,out nIteration))
                return nIteration;
            else
                return 1;
        }
        public int sourceArcs(ref QArray<long> startArc )
        {
            int howMany=0;
            foreach (var i in startArc)
            {
                if (i==0)
                    howMany++;
                else
                    break;// only the first ones should be the ones leading to the end
            }
            return howMany;
        }
        public int sinkArcs(ref QArray<long> endArc,int howManyVertices )//last arcs in the list must have a link to the sinks
        {
            int howMany=0;
            foreach (var i in endArc)
            {
                if (i==howManyVertices-1)
                    howMany++;
            }
            return howMany;
        }
    }
    class Driver
    {
        static void Main(string[] args)
        {
            string answ="1";
            while (answ=="1")
            {
            Utilities u= new Utilities();
            using (var qsim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: false))//It seems that Qubits should be released with Zero state
            {
                int nIteration = u.howManyRuns();
                Double[] avg={0,0,0,0,0,0,0,0,0,0};
                int numberOfVertices=5;
                QArray<long> startArc=  new QArray<long>(0,0,1,2,1,3,3);//0->1 arc, 0->2 arc, 1->2 arc,...
                QArray<long> endArc=    new QArray<long>(1,2,2,3,3,0,4);
                int howManyArcsFromSource=u.sourceArcs(ref startArc);// returns how many arcs are starting from the source
                int howManyArcsToSink=u.sinkArcs(ref endArc,numberOfVertices);

                for (int i = 0; i < nIteration; i++)
                {
                    var rawResult = QMain.Run(qsim,numberOfVertices,startArc,endArc,howManyArcsFromSource,howManyArcsToSink).Result;
                    var resultArray=rawResult.ToArray();
                    for(int j=0;j<endArc.Length;++j)
                    {
                        avg[j]+=resultArray[j]==Result.One?1:0;
                    }
                }
                for (int i = 0; i < endArc.Length; i++)
                {
                    avg[i]=avg[i]/nIteration;
                    System.Console.WriteLine($"Arc {startArc[i]}->{endArc[i]}  QBit {i} have been taken {avg[i]*100}% of times");
                }
            }
            System.Console.WriteLine("Write 1 to continue");
            answ=Console.ReadLine();
            }
        }
    }
}