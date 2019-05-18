using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using quantumGraph;

using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace MFA
{
    class Utilities
    {
        //Default graph schema
        public long[] getSchema()
        {
            long[] arr=
            {
                0,1,1,
                1,1,2,
                0,2,2,
                0,120,3,
                1,10,3,
                3,140,2

            };
            return arr;
        }
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

        
    }
    class Driver
    {
        
        static void quantumEdmondsKarp()
        {
            Utilities u= new Utilities();
            long[] schema=u.getSchema();
            Graph g=new Graph(ref schema,0,2);//We chose to set node 0 as source node, node 2 as sink node
            
            //Graph has been built
            System.Console.WriteLine("Graph has been built.");
            long maxflow=0;
            Path p;
            do{
                g.addLayers();
                g.findPath(out p);
                if(p!=null)
                {
                    System.Console.WriteLine(p.ToString());
                    maxflow=p.applyMaxFlow();
                }
                else
                {maxflow=0;}
            }while(maxflow>0);
            
            
            System.Console.WriteLine("Nodes:");
            foreach (var item in g.nodes)
            {
                System.Console.WriteLine(item.ToString());
            }
             System.Console.WriteLine("Edges:");
            foreach (var item in g.edges)
            {
                System.Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args)
        {
            string answ="1";
            while (answ=="1")
            {
            quantumEdmondsKarp();
            System.Console.WriteLine("Write 1 to restart");
            answ=Console.ReadLine();
            }
        }

    }
}
