    using System.Collections.Generic;
    using System.Linq;

    namespace quantumGraph{
    public static class Graph
    {
        public static Node buildGraph(ref List<Node> nodes,ref List<Edge> edges,ref long[] schema, int rootNode)
        {
            int elementName=0;
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
                    n.Name=elementName.ToString();
                    elementName++;
                    nodes.Add(n);                    
                }

                //create edge
                //System.Console.WriteLine("Adding an edge");
                edges.Add(new Edge(nodes[src],nodes[dest],capacity));
            }
            if(nodes[rootNode]==null)
                throw new System.ArgumentNullException("Graph build failed.");
            nodes[rootNode].Layer=0;
            return nodes[rootNode];
        }
    }
    
    public class Edge
    {
        public Node Source = null;
        public Node Destination = null;
        public long Capacity =0;
        public Edge(Node Source,Node Destination, long Capacity)
        {
            if(Source==null||Destination==null)
                throw new System.ArgumentNullException("Trying to create an edge without source or destination node");
            this.Source=Source;
            this.Destination=Destination;
            this.Capacity=Capacity;
            Source.addOutboundEdge(this);
            Destination.addOutboundEdge(this);
            System.Console.WriteLine("Created edge {"+this.ToString()+"}");
        }

        public override string ToString()
        {
            return "source["+Source.ToString()+"] -- "+Capacity.ToString()+" --> destination["+Destination.ToString()+"]";
        }
    }
    public class Node {
        public string Name="";
        public int Layer;
        public List<Edge> InboundEdges=new List<Edge>();
        public Node(bool isRootNode=false){
            if(isRootNode)
                Layer=0;
            else
                Layer=-1;
        }

        public List<Edge> OutboundEdges=new List<Edge>();

        public Node[] OutboundNodes(){
                List<Node> l=new List<Node>();
                foreach (var edge in this.OutboundEdges)
                {
                    l.Add(edge.Destination);
                }
                
                return l.ToArray();
            }
        public void addInboundEdge(Edge e)
        {
            InboundEdges.Add(e);
            System.Console.WriteLine("Added "+e.ToString());
        }
        public void addOutboundEdge(Edge e)
        {
            OutboundEdges.Add(e);
        }
        public override string ToString()
        {
            return "Name: "+this.Name.ToString()+"\tLayer: "+this.Layer.ToString();
        }
    }


}