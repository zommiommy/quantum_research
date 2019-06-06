using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grover
{
    class Driver
    {
        public static void Pause()
        {
            System.Console.WriteLine("\n\nPress any key to continue...\n\n");
            System.Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // We begin by defining a quantum simulator to be our target
            // machine.
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            //repeats: number of program execution
            var repeats = 10;
            var successCount = 0;

            //n: number of qubit
            //N: size of "database"
            var numDatabaseQubits = 4;
            var databaseSize = Math.Pow(2.0, numDatabaseQubits);

            int markedElement = 7;

            //number of iteraion of Grover's algorithm
            var numIteration = 3; //(Math.PI/4)*Math.Sqrt(databaseSize/numMatches);

            foreach (var idxAttempt in Enumerable.Range(0, repeats))
            {
                ApplyGroverSearch.Run(sim, markedElement, numIteration, numDatabaseQubits).Wait();
                System.Console.WriteLine("\n...\n");
                //HelloQ.Run(sim).Wait();
            }

            Pause();
        }
    }
}