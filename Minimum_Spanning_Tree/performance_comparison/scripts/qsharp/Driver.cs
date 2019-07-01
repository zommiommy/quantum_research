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
            var repeats = 10000;
            var successCount = 0;

            //n: number of qubit
            //N: size of "database"
            var numDatabaseQubits = 10;
            var databaseSize = Math.Pow(2.0, numDatabaseQubits);

            int markedElement = 28;
            int numMatches = 1;

            //number of iteraion of Grover's algorithm
            var numIteration = Convert.ToInt64((Math.PI / 4) * Math.Sqrt(databaseSize / numMatches));
            System.Console.WriteLine("Number of optimal iterations: " + numIteration + "\n\n");

            foreach (var idxAttempt in Enumerable.Range(0, repeats))
            {
                System.Console.WriteLine("Attempt number " + (idxAttempt+1));
                ApplyGroverSearch.Run(sim, markedElement, numIteration, numDatabaseQubits).Wait();
                System.Console.WriteLine("\n\n");
            }
        }
    }
}