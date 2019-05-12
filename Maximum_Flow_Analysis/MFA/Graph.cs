    using System.Collections.Generic;
    using System.Linq;

    namespace quantumGraph{
    public static class Graph
    {
        public static Node buildGraph(ref List<Node> nodes,ref List<Edge> edges,ref long[] schema, int rootNode)
        {
            if(schema.Length%3!=0||rootNode>=System.Math.Ceiling((double)schema.Length/3))
                throw new System.ArgumentException("Schema is not valid. Schema should include arcs triples made as src,capacity,destination.");
            for (int i=0;i<schema.Length;i=i+3)
            {
                int src=(int)schema[i];//It generates an exception if the conversion does an overflow
                long capacity=schema[i+1];
                int dest=(int)schema[i+2];

                while(nodes.Count<(src+1) || nodes.Count<(dest+1))// The source or the destination node (or both) are not in nodes list
                {
                        Node n=new Node();
                        nodes.Append(n);                    
                }

                //create edge
                edges.Append(new Edge(nodes[src],nodes[dest],capacity));
            }
            nodes[rootNode].Layer=0;
        return nodes[rootNode];
        }
    }
    
    public class Edge
    {
        public Node Source {get; private set;}
        public Node Destination {get; private set;}
        public long Capacity{get; private set;}
        public Edge(Node Source, Node Destination, long Capacity)
        {
            this.Source=Source;
            this.Destination=Destination;
            this.Capacity=Capacity;
            Source.addOutboundEdge(this);
            Destination.addOutboundEdge(this);
        }
    }
    public class Node {
        public int Content { get; set; }
        public int Layer {get;set;}
        public Edge[] InboundEdges
        {
            get
            {
                return InboundEdges;
            }
        }
        public Node(bool isRootNode=false){
            if(isRootNode)
                Layer=0;
            else
                Layer=-1;
        }

        public Edge[] OutboundEdges
        {
            get
            {
                return OutboundEdges;
            }
        }

        public Node[] OutboundNodes
        {
            get
            {
                List<Node> l=new List<Node>();
                foreach (var edge in this.OutboundEdges)
                {
                    l.Add(edge.Destination);
                }
                
                return l.ToArray();
            }
        }
        public void addInboundEdge(Edge e)
        {
            InboundEdges.Append(e);
        }
        public void addOutboundEdge(Edge e)
        {
            OutboundEdges.Append(e);
        }
        public override string ToString()
        {
            return this.Layer.ToString();
        }
    }


}