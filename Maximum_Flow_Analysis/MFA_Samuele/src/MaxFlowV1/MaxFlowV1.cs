using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.MaxFlowV1
{
    class Driver
    {
        static void Main(string[] args)
        {
            
            CapacityGraph g = new CapacityGraph(new int[,]
            {
                {0, 7, 1},
                {7, 0, 3},
                {1, 3, 0}
            });
            g.setSourceNode(0);
            g.setSinkNode(2);

            int maxFlow = EdmondsKarp.FindMaxFlow(g.getCapacityMatrix(), g.getNeighbors(), g.getSourceNode(), g.getSinkNode());

            Console.WriteLine($"Max flow = {maxFlow}");

            Console.WriteLine("\n\nPress any key to continue...\n\n");
            Console.ReadKey();
        }
    }
    
}