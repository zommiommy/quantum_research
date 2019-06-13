    using System.Collections.Generic;
    
using System.Xml;
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
        public long quantumErrors=0;
        public List<Node> nodes=new List<Node>();
        public List<Edge> edges=new List<Edge>();
        public Node sourceNode;
        private Random r=new Random();
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
        public void printSchemaAsGEXF(string path="outputGraph.gexf")
        {
            XmlWriterSettings settings = new XmlWriterSettings();  
            settings.Async = true;
            settings.Indent = true;
            settings.IndentChars = "\t";
            using (var gexf = new System.IO.StreamWriter(path))
            using (XmlWriter writer = XmlWriter.Create(gexf, settings))
            {
                writer.WriteStartDocument(true);//<?xml version="1.0" encoding="UTF-8"?>
                {
                    writer.WriteStartElement("gexf","http://www.gexf.net/1.2draft");//<gexf xmlns="http://www.gexf.net/1.2draft" version="1.2">
                    writer.WriteAttributeString("xmlns","http://www.gexf.net/1.2draft");
                    writer.WriteAttributeString("version","1.2");
                    {
                        writer.WriteStartElement("meta");
                        writer.WriteAttributeString("lastmodifieddate",DateTime.Now.ToString("yyyy-MM-dd"));//<meta lastmodifieddate="2009-03-20">
                        {
                            {
                            writer.WriteStartElement("creator");    //<creator>Gexf.net</creator>
                            writer.WriteString(Environment.UserName);
                            writer.WriteEndElement();
                            }
                            {
                                writer.WriteStartElement("description");    //<description>A hello world! file</description>
                                writer.WriteString("Quantum max flow graph");
                                writer.WriteEndElement();
                            }

                        }
                        writer.WriteEndElement();
                    writer.WriteStartElement("graph");//<graph mode="static" defaultedgetype="directed">
                    writer.WriteAttributeString("mode","static");
                    writer.WriteAttributeString("defaultedgetype","directed");
                    {
                        writer.WriteStartElement("nodes");
                        {
                            foreach (var node in nodes) //<node id="0" label="Hello" />
                            {
                                 writer.WriteStartElement("node");
                                 writer.WriteAttributeString("id",node.Index.ToString());
                                 writer.WriteAttributeString("label",node.Index.ToString());
                                 writer.WriteEndElement();
                            }
                        }
                        writer.WriteEndElement();

                        writer.WriteStartElement("edges");
                        {
                            long i=0;
                            foreach (var edge in edges)
                            {
                                writer.WriteStartElement("edge");// <edge id="0" source="0" target="1" />
                                writer.WriteAttributeString("id",i.ToString());
                                writer.WriteAttributeString("source",edge.Source.Index.ToString());
                                writer.WriteAttributeString("target",edge.Destination.Index.ToString());
                                writer.WriteAttributeString("label",edge.Stream.ToString()+"/"+edge.Capacity.ToString());
                                writer.WriteAttributeString("weight",edge.Stream.ToString());
                                writer.WriteEndElement();
                                ++i;
                            }
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    }
                writer.WriteEndElement();//gexf
                }
            }
        }

        public void printSchemaAsDOT(string path="outputGraph.dot")
        {
            using (var dot = new System.IO.StreamWriter(path))
            {
                dot.WriteLine("digraph G");
                dot.WriteLine("{");
                foreach (var node in nodes) 
                {
                    dot.WriteLine(node.Index.ToString());
                }
                StringBuilder s=new StringBuilder();
                foreach (var edge in edges)
                {
                    s.Append(edge.Source.Index);
                    s.Append(" -> ");
                    s.Append(edge.Destination.Index);
                    s.Append(" [label=\" ");
                    s.Append(edge.Stream.ToString());
                    s.Append("/");
                    s.Append(edge.Capacity.ToString());
                    s.Append("\"]");
                    dot.WriteLine(s.ToString());
                    s.Clear();
                }
                dot.WriteLine("}");

            }
        }
        public void printCompactSchemaAsDOT(string path="outputCompactGraph.dot")
        {
            using (var dot = new System.IO.StreamWriter(path))
            {
                dot.WriteLine("digraph G");
                dot.WriteLine("{");
                foreach (var node in nodes) 
                {
                    dot.WriteLine(node.Index.ToString());
                }
                StringBuilder s=new StringBuilder();
                foreach (var edge in edges)
                {
                    if(edge.Stream!=0)
                    {
                    s.Append(edge.Source.Index);
                    s.Append(" -> ");
                    s.Append(edge.Destination.Index);
                    s.Append(" [label=\" ");
                    s.Append(edge.Stream.ToString());
                    s.Append("/");
                    s.Append(edge.Capacity.ToString());
                    s.Append("\"]");
                    dot.WriteLine(s.ToString());
                    s.Clear();
                    }
                }
                dot.WriteLine("}");

            }
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
            int nodesToBeAdded=System.Math.Max(sourceNode,sinkNode)+1 - nodes.Count;
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

            g.resetAllLayers();
            List<Node> reachableNeighbors;
            List<long> nodesLayer;
            List<Edge> takenEdges;
            //END OF INITIALIZATION

            while(q.Count>0)
            {
                Node element=q.Peek();
                element.OutboundNodes(out reachableNeighbors,out takenEdges, out nodesLayer);
                //Node item=null;
                    
                    //Quantum part
                long itemIndex=-1;
                using (var qsim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState:false))
                {
                    itemIndex=findInfiniteLayerNeighbors(qsim,reachableNeighbors,nodesLayer);
                    //The returned index is the one referring to reachableNeighbors list
                }
                if(itemIndex==-1)//no more neighbors
                {
                    System.Console.WriteLine("All neighbors of {"+element.ToString()+"} visited.");
                    //item=null;
                    q.Dequeue();//All neighbors visited
                }
                else if(itemIndex>(reachableNeighbors.Count-1))
                    //if quantum errors happen
                {
                    this.quantumErrors++;
                    System.Console.WriteLine("Quantum run failed, index out of range. Retrying. ");
                }
                else if(nodesLayer[(int)itemIndex]!=-1)
                {
                    this.quantumErrors++;
                    System.Console.WriteLine("Quantum run failed, selected value hasn't infinite layer value. Retrying.");
                }
                else
                {
                    System.Console.WriteLine("Item found:"+reachableNeighbors[(int)itemIndex].ToString());
                    nodesLayer[(int)itemIndex]=element.Layer+1;//change layer in "local" context
                    reachableNeighbors[(int)itemIndex].Layer=element.Layer+1;//Update layer value in global context
                    if(this.sinkNode.Layer==-1)// -1 = infinite layer value
                    {
                        q.Enqueue(reachableNeighbors[(int)itemIndex]);
                        System.Console.WriteLine("Item updated to "+reachableNeighbors[(int)itemIndex].ToString()+" and enqueued.");
                    }
                    else
                    {
                        System.Console.WriteLine("Item updated to "+reachableNeighbors[(int)itemIndex].ToString()+".");
                        System.Console.WriteLine("Item was the sink node. Layering task has finished.\n"+
                        " There is a possible flow between source and sink."
                        );
                    }

                }
            //End of quantum part
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
            {/* 
                if(startingNode==this.sinkNode)
                {
                    System.Console.WriteLine("Flow cannot be increased more.");
                    return;
                }
                else
                {
                System.Console.WriteLine("Infinite distance node. This is weird.");
                return;
                }*/return;
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
                        else if(itemIndex>(reachableNeighbors.Count-1))
                         //if quantum errors happen
                        {
                            System.Console.WriteLine("Quantum run failed, index out of range. Retrying. ");
                            //quantumError=true; //there is no need to do this
                        }
                        else if(nodesLayer[(int)itemIndex]!=layerNumber)
                        {
                            if(layerNumber==-1)
                            System.Console.WriteLine("Quantum run failed, selected value hasn't infinite layer value. Retrying.");
                            else
                            System.Console.WriteLine($"Quantum run failed, selected value hasn't {layerNumber} layer value. Retrying.");
                            this.quantumErrors++;
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
            return findLayerNeighbors(sim,neighbors,associatedLayers,-1);
        }
    
    private long findLayerNeighbors(QuantumSimulator sim,List<Node> neighbors,
    List<long> associatedLayers,long layerNumber)
        {
            //Those should be known a priori! We have no way to define an efficient oracle,
            //neither we know how to develope a smart one, so that's why at the actual state of art
            // we have no reasons to write a quantum algorithm for Maximum Flow problems!

            //If it has to be made in a quantum way, or there is a smart way to build the oracle, or 
            // a whole different approach has to be considered.
            List<long> markedElements = getArcsByLayerNumber(associatedLayers,layerNumber);
            //System.Console.WriteLine($"{markedElements.Count} elements marked for Grover Search.");
            
            int nDatabaseQubits=(int)Math.Ceiling(Math.Log(neighbors.Count,2));//How many neighbors 
            var nMarkedElements = markedElements.Count;
            Console.Write("Elements to be found are: [ ");
            foreach (var item in markedElements)
            {
                if(item>Math.Pow(2,nDatabaseQubits))
                    throw new ArgumentOutOfRangeException("Item to be found is out of range");
                Console.Write(item.ToString()+", ");        
            }
            Console.WriteLine("] in a dataset of size "+neighbors.Count.ToString());
            Console.WriteLine("Actual size of the dataset: "+Math.Pow(2,nDatabaseQubits).ToString());        
            int nIterations;
            if(r.Next(0,2)==0)
                nIterations=(int)Math.Floor(Math.PI/4*Math.Sqrt(Math.Pow(2,nDatabaseQubits)));
            else
                nIterations=(int)Math.Ceiling(Math.PI/4*Math.Sqrt(Math.Pow(2,nDatabaseQubits)));
            if (nMarkedElements==0)
                return -1;
            Console.WriteLine("Diffusion iterations: "+nIterations.ToString());    
            var task = MFA.ApplyGroverSearch.Run(sim, new QArray<long>(markedElements), nIterations, nDatabaseQubits);
            var data = task.Result;
            Console.WriteLine("Outcome is "+task.Result);
                //var success= data.Item1;
            var databaseRegister = data.Item2;
            return databaseRegister;
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