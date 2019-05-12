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

        public long[] getInfiniteArcs(int[] arcs)
        {
            var l=new List<long>();
            for(int i=0;i<arcs.Length;++i)
            {
                if (arcs[i]==-1)
                    l.Add(i);
            }
            return l.ToArray();
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
            long[] schema=u.getSchema();
            List<Node> nodes=new List<Node>();
            List<Edge> edges= new List<Edge>();
            Node rootNode=Graph.buildGraph(ref nodes,ref edges,ref schema,0);//We chose to set node 0 as root
            if(rootNode==null)
                throw new System.ArgumentNullException("Graph build failed.");
            
            //Graph has been built.
            System.Console.WriteLine("Graph has been built.");
            //Start layering

            Queue<Node> q=new Queue<Node>();
            q.Append(rootNode);
            int i=1;//layer value
            while(q.Count>0)
            {
                Node element=q.Peek();
                Node[] neighbors=element.OutboundNodes;
                Node item=null;
                do{//While there are neighbors with infinite distance
                    List<int> layerList=new List<int>();
                    for(int j=0;j<neighbors.Length;++j)
                    {
                        layerList.Add(neighbors[j].Layer);
                    }

                    //Quantum part
                    bool notValid=true;//Quantum part result is not valid
                    while(notValid)
                    {
                        using (var qsim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState:false))
                        {
                            int itemIndex=findInfiniteLayerNeighbors(qsim,layerList.ToArray());
                            
                            if(layerList[itemIndex]!=-1)//if item found by Grover search is not a -1
                                System.Console.WriteLine("Quantum run failed. Retrying.");
                            else
                            {
                                item=neighbors[itemIndex];
                                item.Layer=i;//assigning correct layer number
                                notValid=false;
                            }
                        }
                    }
                    //End of quantum part

                    if(item!=null)
                    {
                        q.Enqueue(item);
                    }
                    else
                    { 
                        q.Dequeue();//All neighbors visited
                    }
                    
                }while(item!=null);//While there are neighbors with infinite distance
                i++;//Incrementing layer value
                
            }

            System.Console.WriteLine(nodes);
            System.Console.WriteLine("Write 1 to continue");
            answ=Console.ReadLine();
            }
        }

        static int findInfiniteLayerNeighbors(QuantumSimulator sim,int[] layerArray)
        {
            //Those should be known a priori! We have no way to define an efficient oracle,
            //neither we know how to develope a smart one, so that's why at the actual state of art
            // we have no reasons to write a quantum algorithm for Maximum Flow problems!

            //If it has to be made in a quantum way, or there is a smart way to build the oracle, or 
            // a whole different approach has to be considered.
            var markedElements = new Utilities().getInfiniteArcs(layerArray);

            int nDatabaseQubits=layerArray.Length;//How many neighbors 
            var nMarkedElements = markedElements.Length;
            var nIterations=3;//TODO set the correct value calculated theorically
            
            var task = ApplyGroverSearch.Run(sim, new QArray<long>(markedElements), nIterations, nDatabaseQubits);

            var data = task.Result;
                //var success= data.Item1;
            var databaseRegister = data.Item2;
            return (int)databaseRegister;
        }
    }
}