    using System.Collections.Generic;
    using System.Linq;
    namespace quantumGraph{
    public class Graph
    {
        public List<Node> nodes=new List<Node>();
        public List<Edge> edges=new List<Edge>();

        public Node sourceNode;
        public Node sinkNode;
        private void createNode(ref int elementName,bool isSourceNode,bool isSinkNode)
        {
            Node n=null;
            if (isSourceNode)
            {
                n=new Node(true);
                this.sourceNode=n;
            }
            else
            {
                n=new Node();
            }

            if (isSinkNode)
            {
                sinkNode=n;
            }
            n.Name=elementName.ToString();
            elementName++;
            this.nodes.Add(n);
        }
        private void createEdge(Node startingNode,Node endingNode, long capacity)
        {
                this.edges.Add(new Edge(startingNode,endingNode,capacity));
        }
        public Graph(ref long[] schema,
         int sourceNode,int sinkNode)
        {
            int elementName=0;
            if(schema.Length%3!=0||sourceNode>=System.Math.Ceiling((double)schema.Length/3))
                throw new System.ArgumentException("Schema is not valid. Schema should include arcs triples made as src,capacity,destination.");
            
            for (int i=0;i<schema.Length;i=i+3)
            {
                int src=(int)schema[i];//It generates an exception if the conversion does an overflow
                long capacity=schema[i+1];
                int dest=(int)schema[i+2];

                while(this.nodes.Count<(src+1) || this.nodes.Count<(dest+1))// The source or the destination node (or both) are not in nodes list
                {
                    createNode(ref elementName,elementName==sourceNode,elementName==sinkNode);                  
                }

                //create edge
                createEdge(this.nodes[src],this.nodes[dest],capacity);
            }
            //Add some extra nodes if required
            int nodesToBeAdded=System.Math.Max(sourceNode,sinkNode)+1 - nodes.Count();
            for(int j=0;j<nodesToBeAdded;j++)//in case the required nodes are not linked with other nodes
            {
                createNode(ref elementName,elementName==sourceNode,elementName==sinkNode); 
            }
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