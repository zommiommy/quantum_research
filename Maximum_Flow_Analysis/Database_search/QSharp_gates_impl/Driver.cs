using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QSharpApplication2
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
            using (var qsim = new QuantumSimulator())
            {
                var results = HelloQ.Run(qsim).Result;
                Console.WriteLine(results);
            }
            Pause();
        }
    }
}