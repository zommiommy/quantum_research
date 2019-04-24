using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Linq;

namespace Quantum.DatabaseSearch
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Setup

            // We begin by defining a quantum simulator to be our target machine.
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            #endregion

            int groverIterations;
            int nDatabaseQubits = 10;
            int repeats;

            #region Random Database Search with Manual Oracle Definitions

            // Let us investigate the success probability of CLASSICAL random search.
            // This corresponds to the case where we do not perform any Grover iterates
            groverIterations = 0;

            // Let us repeat more times to collect enough statistics
            repeats = 10000;

            // We define 13 as the marked element. This must be smaller than `databaseSize`

            performDatabaseSearch(sim, nDatabaseQubits, repeats, groverIterations, new QArray<long>() { 13 });
            Pause();

            #endregion

            #region Single Element Quantum Database Search with the Canon

            // We will perform more Grover iterates to amplify the marked subspace.
            groverIterations = 3;

            // as the probability is higher with quantum search, we need less repeats
            repeats = repeats / 10;

            // We define 13 as the marked element. This must be smaller than `databaseSize`

            performDatabaseSearch(sim, nDatabaseQubits, repeats, groverIterations, new QArray<long>() { 13 });
            Pause();

            #endregion

            #region Multiple Element Quantum Database Search with the Canon
            
            groverIterations = 3;

            // We define the marked elements. These must be smaller than `databaseSize`
            QArray<long> markedElements = new QArray<long>() { 0, 15, 48, 62 };

            // as the probability is higher with multiple input, we need even less repeats
            repeats = repeats / (int)markedElements.Length;

            performDatabaseSearch(sim, nDatabaseQubits, repeats, groverIterations, markedElements);
            Pause();

            #endregion

        }

        public static void Pause()
        {
            System.Console.WriteLine("\n\nPress any key to continue...\n\n");
            System.Console.ReadKey();
        }

        static void performDatabaseSearch(
            QuantumSimulator sim,
            int nDatabaseQubits,
            int repeats,
            int groverIterations,
            QArray<long> markedElements)
        {
            // We define the size `N` = 2^n of the database to searched in terms of number of qubits `n`. 
            long databaseSize = (long) Math.Pow(2.0, nDatabaseQubits);

            long nMarkedElements = markedElements.Length;
            
            // Number of queries to database oracle.
            int queries = groverIterations * 2 + 1;

            // We now execute the quantum search and verify that the success 
            // probability matches the theoretical prediction. 
            double classicalSuccessProbability = (double)(nMarkedElements) / databaseSize;
            double quantumSuccessProbability = Math.Pow(Math.Sin((2.0 * (double)groverIterations + 1.0) * Math.Asin(Math.Sqrt(nMarkedElements) / Math.Sqrt(databaseSize))), 2.0);
            int successCount = 0;

            
            if (groverIterations > 0)
            {
                Console.Write(
                $"\n\nQuantum search for marked element in database.\n" +
                $"  Database size: {databaseSize}.\n" +
                $"  Marked elements: {string.Join(",", markedElements.Select(x => x.ToString()).ToArray())}\n" +
                $"  Classical success probability: {classicalSuccessProbability}\n" +
                $"  Oracle queries per search: {queries} \n" +
                $"  Quantum success probability: {quantumSuccessProbability}\n\n");
            }
            else
            {
                Console.Write(
                $"\n\nClassical search for marked element in database.\n" +
                $"  Database size: {databaseSize}.\n" +
                $"  Marked elements: {string.Join(",", markedElements.Select(x => x.ToString()).ToArray())}\n" +
                $"  Classical success probability: {classicalSuccessProbability}\n\n");
            }
            

            foreach (var idxAttempt in Enumerable.Range(1, repeats+1))
            {
                // Each operation has a static method called Run which takes a simulator as
                // an argument, along with all the arguments defined by the operation itself.  
                var task = ApplyGroverSearch.Run(sim, markedElements, groverIterations, nDatabaseQubits);

                // We extract the return value of the operation by getting the Results property.
                var data = task.Result;

                // Extract the marked qubit state
                var markedQubit = data.Item1;
                var databaseRegister = data.Item2;

                successCount += markedQubit == Result.One ? 1 : 0;

                // Print 10 sample results of the attempts
                if (idxAttempt % (repeats/10) == 0)
                {
                    var empiricalSuccessProbability = Math.Round((double)successCount / ((double)idxAttempt + 1), 5);

                    // This is how much faster the quantum algorithm performs on average
                    // over the classical search.
                    var speedupFactor = Math.Round(empiricalSuccessProbability / classicalSuccessProbability / (double)queries, 3);

                    Console.Write(
                        $"    Attempt {idxAttempt}: " +
                        ((markedQubit == Result.One) ? "Success. " : "Fail. " ) +
                        $"Found database index {databaseRegister} \n");

                    if (groverIterations > 0)
                    {
                        Console.Write(
                            $"Up to now success frequency: {empiricalSuccessProbability}" +
                            $" => Speedup: {speedupFactor}\n\n");
                    }
                    else
                    {
                        Console.Write(
                            $"Up to now success frequency: {empiricalSuccessProbability}\n\n");
                    }
                }
            }
        }

    }

}
