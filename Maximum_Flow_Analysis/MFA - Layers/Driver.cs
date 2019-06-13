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
                1,1,3,
                0,2,2,
                2,120,3,
                1,10,3,

            };
            return arr;
        }
        public long[] getRandomSchema(int rows,int src,int sink)
        {
            List<long> arr= new List<long>();
            Random r=new Random();
            int numberOfNodes= Math.Max(rows/5,3);
            int numberOfLayers=Math.Max((int)Math.Round(Math.Log10((double)rows)*Math.Log10((double)rows)+2) , 2);//this could be tuned, a lower value
            
            List<int>[] layersLists=new List<int>[numberOfLayers];
            bool emptyList=true;
            int howManyRepeats=0;
            while(emptyList)//layer assignment
            {
                for (int i = 0; i < layersLists.Length; i++)
                {
                    layersLists[i]=new List<int>();
                }
                int srcLayer=-1,snkLayer=-1;

                for (int node=0;node<numberOfNodes;++node)
                {
                    int index;
                    if(node==src)
                    {/* //it is better to set the srcLayer as the first one and the sink one as the last one, so that the graph becomes more meaningful
                        if(snkLayer==-1)
                            index=r.Next(0,numberOfLayers-1);
                        else
                            index=r.Next(0,snkLayer);//assign it in a layer antecedent to the destination one
                        */
                        index=0;
                        srcLayer=index;
                    }
                    else if(node==sink)
                    {/*
                        if(srcLayer==-1)
                            index=r.Next(1,numberOfLayers);
                        else
                            index=r.Next(srcLayer+1,numberOfLayers);
                        */
                        
                        index=numberOfLayers-1;
                        snkLayer=index;
                    }
                    else
                    {
                        index=r.Next(0,numberOfLayers);
                    }
                    Console.WriteLine($"index={index} node={node}");
                    layersLists[index].Add(node);
                }
                
                emptyList=false;
                
                for (int i = 0; i < layersLists.Length; i++)
                {
                    if(layersLists[i].Count==0)
                    {
                        Console.WriteLine($"List {i} is empty");
                        emptyList=true;
                        //break;
                    }
                }

                if(howManyRepeats>3)
                {
                    Console.WriteLine("Shrink.");
                    if(numberOfLayers==2)
                        Console.WriteLine("Or you are very unlucky, or there is a bug in graph generation function");
                    numberOfLayers--;
                    layersLists=new List<int>[numberOfLayers];
                    emptyList=true;
                    howManyRepeats=-1;
                }
                howManyRepeats++;
            }//end of layer assignment


            HashSet<KeyValuePair<int, int>> arcPairs = new HashSet<KeyValuePair<int, int>>();
            int maxConsecutiveFailures= Math.Max(rows,10);//seems a reasonable value
            
            for (int i = 0; i < rows; i++)
            {
                int consecutiveFailures=-1;
                KeyValuePair<int, int> pair;
                int startingLayer;
                int startingValue;
                int destinationValue;
                do
                {consecutiveFailures++;
                
                startingLayer=r.Next(0,numberOfLayers-1);//last layer is not a valid one
                int valSrcIndex=r.Next(0,layersLists[startingLayer].Count);//pick an index of a value from the starting layer list
                int valDstIndex=r.Next(0,layersLists[startingLayer+1].Count);//pick an index of a value from the ending layer list
                startingValue=layersLists[startingLayer][valSrcIndex];
                destinationValue=layersLists[startingLayer+1][valDstIndex];
                pair=new KeyValuePair<int, int>(startingValue,destinationValue);

                
                } while(arcPairs.Contains(pair)&&consecutiveFailures<maxConsecutiveFailures);
                if(consecutiveFailures<maxConsecutiveFailures)
                {
                arr.Add(startingValue);
                arr.Add(r.Next(1,30000));
                arr.Add(destinationValue);
                arcPairs.Add(pair);
                }
                
            }
            return arr.ToArray();
        }

        public long[] getRandomSchemaNotLayered(int rows,int src,int sink)
        {
            List<long> arr= new List<long>();
            Random r=new Random();
            int numberOfNodes= Math.Max(rows/5,3);
            

            HashSet<KeyValuePair<int, int>> arcPairs = new HashSet<KeyValuePair<int, int>>();
            int maxConsecutiveFailures= Math.Max(rows,10);//seems a reasonable value
            
            for (int i = 0; i < rows; i++)
            {
                int consecutiveFailures=-1;
                KeyValuePair<int, int> pair;
                int startingValue;
                int destinationValue;
                do
                {consecutiveFailures++;
                
                startingValue=r.Next(0,numberOfNodes);//pick an index of a value from the starting layer list
                destinationValue=r.Next(0,numberOfNodes);//pick an index of a value from the ending layer list
                pair=new KeyValuePair<int, int>(startingValue,destinationValue);
                } while(arcPairs.Contains(pair)&&consecutiveFailures<maxConsecutiveFailures&&startingValue==destinationValue);
                if(consecutiveFailures<maxConsecutiveFailures&&startingValue!=destinationValue)
                {
                arr.Add(startingValue);
                arr.Add(r.Next(1,30000));
                arr.Add(destinationValue);
                arcPairs.Add(pair);
                }
                
            }
            return arr.ToArray();
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
        
        private const int defaultSize=30;
        public int getRandomSchemaDesiredSize()
        {
            System.Console.WriteLine($"Write the approximate number of arcs of the graph to be generated (default: {defaultSize})");
                    var answ=Console.ReadLine();
                    int l;
                    if(int.TryParse(answ, out l))
                    {
                        if(l>2)
                            return l;

                    }
                    return defaultSize;
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
            Console.WriteLine("Quantum errors: "+g.quantumErrors);
            g.printSchemaAsDOT();
            g.printSchemaAsGEXF();
            g.printCompactSchemaAsDOT();

        }
        static void Main(string[] args)
        {
            string answ="1";
            while (answ=="1")
            {
            Utilities u= new Utilities();
            long[] schema;
            if(args.Length==0)
            {
                System.Console.WriteLine("Write whatever for a random initialization, or write 1 for the default one");
                answ=Console.ReadLine();
                if(answ!="1")
                    schema=u.getRandomSchemaNotLayered(u.getRandomSchemaDesiredSize(),src:0,sink:2);           
                else
                    schema=u.getSchema();

            }
            else
                schema=u.getSchemaFromFile(args[0]);
            Graph g;
            g=new Graph(ref schema,0,2);//We chose to set node 0 as source node, node 2 as sink node
            quantumEdmondsKarp(g);
            System.Console.WriteLine("Write 1 to restart");
            answ=Console.ReadLine();
            }
        }

    }
}
