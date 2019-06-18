using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.PhoneBook
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
            int q0, q1, q2;

            using (var qsim = new QuantumSimulator())
            {
                for (q0 = 0; q0 <= 1; q0++)
                    for (q1 = 0; q1 <= 1; q1++)
                        for (q2 = 0; q2 <= 1; q2++)
                        {
                            Console.WriteLine("Input:  (" + q0 + ", " + q1 + ", " + q2 + ")");
                            Result in0 = (q0 == 0 ? Result.Zero : Result.One);
                            Result in1 = (q1 == 0 ? Result.Zero : Result.One);
                            Result in2 = (q2 == 0 ? Result.Zero : Result.One);
                            (float, float, float) out_var = (0, 0, 0);
                            int iterations = 100;
                            for (int i = 0; i < iterations; i++)
                            {
                                var results = PhoneBookSearch.Run(qsim, in0, in1, in2).Result;
                                out_var.Item1 += (results.Item1 == Result.Zero ? 0 : 1);
                                out_var.Item2 += (results.Item2 == Result.Zero ? 0 : 1);
                                out_var.Item3 += (results.Item3 == Result.Zero ? 0 : 1);
                            }
                            out_var.Item1 /= iterations;
                            out_var.Item2 /= iterations;
                            out_var.Item3 /= iterations;

                            Console.WriteLine("Output: " + out_var + "\n");
                        }

            }
            Pause();
        }
    }
}