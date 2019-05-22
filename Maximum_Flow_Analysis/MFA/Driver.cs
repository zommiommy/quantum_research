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
        public long[] getSchemaFromFile(string path)
        {
            List<long> arr;
             using (System.IO.StreamReader streamReader = new System.IO.StreamReader(path))
            {
                using (var csv = new CsvHelper.CsvReader(streamReader))
                {    csv.Configuration.HasHeaderRecord = false;
                    var arr2 = csv.GetRecords<long>();
                    arr=new List<long>(arr2);
                }
            }
            return arr.ToArray();
        }
        
    }
    class Driver
    {
        
        static void quantumEdmondsKarp(Graph g)
        {
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
            g.printSchemaAsDOT();
            g.printSchemaAsGEXF();

        }
        static void Main(string[] args)
        {
            string answ="1";
            while (answ=="1")
            {
            Utilities u= new Utilities();
            long[] schema;
            if(args.Length==0)
                schema=u.getSchema();
            else
                schema=u.getSchemaFromFile(args[0]);

            Graph g=new Graph(ref schema,0,2);//We chose to set node 0 as source node, node 2 as sink node
            quantumEdmondsKarp(g);
            System.Console.WriteLine("Write 1 to restart");
            answ=Console.ReadLine();
            }
        }

    }
}
