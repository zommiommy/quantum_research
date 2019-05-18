    using System.Collections.Generic;
    using System.Linq;

    using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using quantumGraph;

using System.Text;
using System.Threading.Tasks;
using static System.Math;

    namespace quantumGraph{
    public class Graph
    {
        public List<Node> nodes=new List<Node>();
        public List<Edge> edges=new List<Edge>();
        public Node sourceNode;
        public Node sinkNode;
        public void resetAllLayers()
        {
            foreach (var item in this.nodes)
            {
                item.Layer=-1;
            }
            this.sourceNode.Layer=0;
        }
        private void createNode(ref int elementIndex,bool isSourceNode,bool isSinkNode)
        {
            Node n=new Node();
            if (isSourceNode)
            {
                this.sourceNode=n;
                this.sourceNode.Layer=0;
            }

            if (isSinkNode)
            {
                sinkNode=n;
            }
            n.Index=elementIndex;
            elementIndex++;
            this.nodes.Add(n);
        }
        private void createEdge(Node startingNode,Node endingNode, long capacity)
        {
                this.edges.Add(new Edge(startingNode,endingNode,capacity));
        }
        public Graph(ref long[] schema,
         int sourceNode,int sinkNode)
        {
            int elementIndex=0;
            if(schema.Length%3!=0||sourceNode>=System.Math.Ceiling((double)schema.Length/3))
                throw new System.ArgumentException("Schema is not valid. Schema should include arcs triples made as src,capacity,destination.");
            
            for (int i=0;i<schema.Length;i=i+3)
            {
                int src=(int)schema[i];//It generates an exception if the conversion does an overflow
                long capacity=schema[i+1];
                int dest=(int)schema[i+2];

                while(this.nodes.Count<(src+1) || this.nodes.Count<(dest+1))// The source or the destination node (or both) are not in nodes list
                {
                    createNode(ref elementIndex,elementIndex==sourceNode,elementIndex==sinkNode);                  
                }

                //create edge
                createEdge(this.nodes[src],this.nodes[dest],capacity);
            }
            //Add some extra nodes if required
            int nodesToBeAdded=System.Math.Max(sourceNode,sinkNode)+1 - nodes.Count();
            for(int j=0;j<nodesToBeAdded;j++)//in case the required nodes are not linked with other nodes
            {
                createNode(ref elementIndex,elementIndex==sourceNode,elementIndex==sinkNode); 
            }

        }


   public void addLayers()
        {
            Graph g=this;
            //Start layering
            Queue<Node> q=new Queue<Node>();
            q.Enqueue(g.sourceNode);
            long i=1;//layer value, source node layer value is set to 0 when constructed
            
            //nodes associated layers
            g.resetAllLayers();
            List<Node> reachableNeighbors;
            List<long> nodesLayer;
            List<Edge> takenEdges;
            //END OF INITIALIZATION

            while(q.Count>0)
            {
                Node element=q.Peek();
                element.OutboundNodes(out reachableNeighbors,out takenEdges, out nodesLayer);
                Node item=null;
                do
                {
                    //While there are neighbors with infinite distance
                    //Quantum part
                    bool quantumError=true;//Quantum part result is not valid
                    do
                    {
                        //look in all reachachable neighbors
                        long itemIndex=0;
                        using (var qsim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState:false))
                        {
                            itemIndex=findInfiniteLayerNeighbors(qsim,reachableNeighbors,nodesLayer);
                            //The returned index is the one referring to reachableNeighbors list
                            //assert(reachableNeighbors.Count==nodesLayer.Count,true);
                        }
                        if(itemIndex==-1)//no more neighbors
                        {
                            System.Console.WriteLine("All neighbors of {"+element.ToString()+"} visited.");
                            quantumError=false;
                            item=null;
                        }
                        else if(itemIndex>(reachableNeighbors.Count-1) ||
                         nodesLayer[(int)itemIndex]!=-1)//unsafe, to be fixed
                         //if quantum errors happen
                        {
                            System.Console.WriteLine("Quantum run failed. Retrying.");
                            //quantumError=true; //there is no need to do this
                        }
                        else
                        {
                            System.Console.WriteLine("Item Index:"+itemIndex.ToString());
                            item=reachableNeighbors[(int)itemIndex];
                            System.Console.WriteLine($"Layer value changing from {nodesLayer[(int)itemIndex].ToString()} to {i.ToString()}");
                            nodesLayer[(int)itemIndex]=i;//change layer in "local" context
                            
                            reachableNeighbors[(int)itemIndex].Layer=i;//Update layer value in global context
                            quantumError=false;
                        }

                    }while(quantumError);//keep cycling if quantum part fails
                    //End of quantum part

                    if(item!=null)
                    {
                        q.Enqueue(item);
                    }
                }while(item!=null);//While there are neighbors with infinite distance
                
                i++;//Incrementing layer value
                q.Dequeue();//All neighbors visited  
            }
        }
        public void findPath(out Path path)
        {
            findInnerPath(out path ,this.sinkNode,null);
        }
        private void findInnerPath(out Path path,Node startingNode,Edge usedEdge)
        {
            Graph g=this;
            long layerNumber=startingNode.Layer;
            path=null;
            
            if(startingNode.Layer==-1)
            {
                if(startingNode==this.sinkNode)
                {
                    System.Console.WriteLine("Flow cannot be increased more.");
                    return;
                }
                else
                {
                System.Console.WriteLine("Infinite distance node. This is weird.");
                return;
                }
            }
            path=new Path();
            if(startingNode.Layer==0)
            {
                path.Nodes.Insert(0,startingNode);
                if(usedEdge!=null)
                    path.Edges.Insert(0,usedEdge);
                return;
            }
            List<Node> reachableNeighbors;
            List<long> nodesLayer;
            List<Edge> takenEdges;
            //END OF INITIALIZATION

             layerNumber--;
                startingNode.InboundNodes(out reachableNeighbors,out takenEdges, out nodesLayer);
                
                //Quantum part
                    bool quantumError=true;//Quantum part result is not valid
                    do
                    {
                        //look in all reachable neighbors
                        long itemIndex=0;
                        using (var qsim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState:false))
                        {
                            itemIndex=findLayerNeighbors(qsim,reachableNeighbors,nodesLayer,layerNumber);
                            //assert(reachableNeighbors.Count==nodesLayer.Count,true);
                        }
                        if(itemIndex==-1)//no more neighbors
                        {
                            throw new Exception("All neighbors of {"+startingNode.ToString()+"} visited. No one has layer "+layerNumber.ToString()
                            +". This is a bug in layering functions.");
                        }
                        else if(itemIndex>(reachableNeighbors.Count-1) ||
                         nodesLayer[(int)itemIndex]!=layerNumber)//unsafe, to be fixed
                         //if quantum errors happen
                        {
                            System.Console.WriteLine("Quantum run failed. Retrying.");
                            //quantumError=true; //there is no need to do this
                        }
                        else
                        {
                            System.Console.WriteLine("Item Index:"+itemIndex.ToString());
                            Node item=reachableNeighbors[(int)itemIndex];
                            Edge takenEdge=takenEdges[(int)itemIndex];
                            Path subPath;
                            findInnerPath(out subPath,item,takenEdge);
                            if(subPath==null)//Dead run, should never happen
                            {
                                path=null;
                                quantumError=false;//No quantum errors happened
                                throw new Exception("Found a neighbor of {"+startingNode.ToString()+"} which has layer "+layerNumber.ToString()
                            +" but no way to reach the sourceNode. This is a bug in layering functions.");
                            }
                            else//there is a path leading to a Layer 0 node
                            {
                                path.Append(subPath);//Path was empty
                                path.Nodes.Add(startingNode);
                                if(usedEdge!=null)
                                    path.Edges.Add(usedEdge);
                                quantumError=false;
                            }
                        }

                    }while(quantumError);//keep cycling if quantum part fails
                    //End of quantum part
            
        }

private long findInfiniteLayerNeighbors(QuantumSimulator sim,List<Node> neighbors,List<long> associatedLayers)
        {
            //Those should be known a priori! We have no way to define an efficient oracle,
            //neither we know how to develope a smart one, so that's why at the actual state of art
            // we have no reasons to write a quantum algorithm for Maximum Flow problems!

            //If it has to be made in a quantum way, or there is a smart way to build the oracle, or 
            // a whole different approach has to be considered.
            var markedElements = getInfiniteArcs(associatedLayers);
            //System.Console.WriteLine($"{markedElements.Count} elements marked for Grover Search.");
            int nDatabaseQubits=neighbors.Count;//How many neighbors 
            var nMarkedElements = markedElements.Count;
            var nIterations=3;//TODO set the correct value calculated theorically
            if (nMarkedElements==0)
                return -1;
            var task = MFA.ApplyGroverSearch.Run(sim, new QArray<long>(markedElements), nIterations, nDatabaseQubits);

            var data = task.Result;
                //var success= data.Item1;
            var databaseRegister = data.Item2;
            return databaseRegister;
        }
    
    private long findLayerNeighbors(QuantumSimulator sim,List<Node> neighbors,List<long> associatedLayers,long layerNumber)
        {
            //Those should be known a priori! We have no way to define an efficient oracle,
            //neither we know how to develope a smart one, so that's why at the actual state of art
            // we have no reasons to write a quantum algorithm for Maximum Flow problems!

            //If it has to be made in a quantum way, or there is a smart way to build the oracle, or 
            // a whole different approach has to be considered.
            var markedElements = getArcsByLayerNumber(associatedLayers,layerNumber);
            //System.Console.WriteLine($"{markedElements.Count} elements marked for Grover Search.");
            int nDatabaseQubits=neighbors.Count;//How many neighbors 
            var nMarkedElements = markedElements.Count;
            var nIterations=3;//TODO set the correct value calculated theorically
            if (nMarkedElements==0)
                return -1;
            var task = MFA.ApplyGroverSearch.Run(sim, new QArray<long>(markedElements), nIterations, nDatabaseQubits);

            var data = task.Result;
                //var success= data.Item1;
            var databaseRegister = data.Item2;
            return databaseRegister;
        }

        private List<long> getInfiniteArcs(List<long> arcs)
        {
            return getArcsByLayerNumber(arcs,-1);
        }
        private List<long> getArcsByLayerNumber(List<long> arcs,long layerNumber)
        {
            var l=new List<long>();
            for(int i=0;i<arcs.Count;++i)
            {
                if (arcs[i]==layerNumber)
                    l.Add(i);
            }
            return l;
        }
    

    }
    
    public class Edge
    {
        public Node Source = null;
        public Node Destination = null;
        public long Capacity {get;private set;}
        public long Stream{get;private set;}
        public Edge(Node Source,Node Destination, long Capacity)
        {
            if(Source==null||Destination==null)
                throw new System.ArgumentNullException("Trying to create an edge without source or destination node");
            this.Source=Source;
            this.Destination=Destination;
            this.Capacity=Capacity;
            Source.addOutboundEdge(this);
            Destination.addInboundEdge(this);
            System.Console.WriteLine("Created edge {"+this.ToString()+"}");
            if(Source==Destination)
                throw new System.ArgumentException("Self connected arcs are not accepted");
        }
        public void addStream(long stream)
        {
            if(isFlowReversed())
            {
                this.Stream+=-stream;
            }
            else
            {
                this.Stream+=stream;
            }
        }
        public bool allowsFlowIncrease()
        {
            return Stream<Capacity;
        }
        public bool allowsFlowDecrease()
        {
            return Stream>0;
        }
        public override string ToString()
        {
            return "source["+Source.ToString()+"] -- "+Stream.ToString()+"/"+Capacity.ToString()+" --> destination["+Destination.ToString()+"]";
        }
        private bool isFlowReversed()
        {
            return Source.Layer>Destination.Layer;
        }
        public long getMaxFlow()
        {
            
            //System.Console.WriteLine($"getMaxFlow: {this.ToString()}  isFlowReversed: {isFlowReversed()}");
            if(isFlowReversed())
            {
                return Stream;
            }
            else
            {
                return Capacity-Stream;
            }
        }
    }
    public class Node {
        public long Index=-1;
        public long Layer=-1;
        public List<Edge> InboundEdges=new List<Edge>();
        public Node(){}

        public List<Edge> OutboundEdges=new List<Edge>();

        public void OutboundNodes(out List<Node> nodes,out List<Edge> takenEdges,out List<long> layers){
                nodes=new List<Node>();
                takenEdges=new List<Edge>();
                layers=new List<long>();
                foreach (var edge in this.OutboundEdges)
                {
                    if(edge.allowsFlowIncrease())
                    {   
                        nodes.Add(edge.Destination);
                        takenEdges.Add(edge);
                        layers.Add(edge.Destination.Layer);
                    }
                }
                foreach (var edge in this.InboundEdges)
                {
                    if(edge.allowsFlowDecrease())
                    {   
                        nodes.Add(edge.Source);
                        takenEdges.Add(edge);
                        layers.Add(edge.Source.Layer);
                    }
                }
            }

        public void InboundNodes(out List<Node> nodes,out List<Edge> takenEdges,out List<long> layers){
            nodes=new List<Node>();
            takenEdges=new List<Edge>();
            layers=new List<long>();
            foreach (var edge in this.InboundEdges)
            {
                if(edge.allowsFlowIncrease())
                {
                    nodes.Add(edge.Source);
                    takenEdges.Add(edge);
                    layers.Add(edge.Source.Layer);
                }
            }
            foreach (var edge in this.OutboundEdges)
            {
                if(edge.allowsFlowDecrease())
                {
                    nodes.Add(edge.Destination);
                    takenEdges.Add(edge);
                    layers.Add(edge.Destination.Layer);
                }
            }
        }
        public void addInboundEdge(Edge e)
        {
            InboundEdges.Add(e);
        }
        public void addOutboundEdge(Edge e)
        {
            OutboundEdges.Add(e);
        }
        public override string ToString()
        {
            return "Index: "+this.Index.ToString()+" Assigned Layer: "+this.Layer.ToString();
        }
    }


public class Path
{public List<Edge> Edges=new List<Edge>();

//We assume that the path is a valid one
public long applyMaxFlow()
{
    if (Nodes.Count==0)
        throw new Exception("Calculated flow for a null path");
    else
    {
        if(Edges.Count==0)
        {System.Console.WriteLine("Calculating max flow which is 0");
            return 0;
        }
        else
        {
            System.Console.WriteLine("Calculating max flow");
            bool firstIteration=true;
            long maxflow=-1;
            foreach (var edge in Edges)
            {
                long edgeMaxFlow=edge.getMaxFlow();
                if(firstIteration)
                {
                    maxflow=edgeMaxFlow;
                    firstIteration=false;
                }
                else if(edgeMaxFlow<maxflow)
                    maxflow=edgeMaxFlow;
                
            }
            foreach (var edge in Edges)
            {
                edge.addStream(maxflow);
            }
            System.Console.WriteLine($"max flow={maxflow}");
            return maxflow;
        } 
    }

}
public List<Node> Nodes=new List<Node>();
public void Append(Path p)
{
    this.Edges.AddRange(p.Edges);
    this.Nodes.AddRange(p.Nodes);
}
public Path()
{}
public override string ToString()
{
    if(Nodes.Count==0)
        return "No path";
    else
    {
        StringBuilder s=new StringBuilder();
        for (int i = 0; i < Nodes.Count; i++)
        {
            s.Append(Nodes[i].Index);
            if(i < Edges.Count)
            {
                bool reversed=Edges[i].Destination==Nodes[i];
                if(reversed)
                    s.Append(" <-- ");
                else
                    s.Append(" -- ");
                s.Append(Edges[i].Capacity);
                if(reversed)
                    s.Append(" -- ");
                else
                    s.Append(" --> ");
            }
        }
        return s.ToString();
    }
}
}
}