using System.Collections.Generic;

public class CapacityGraph
{
    private int nodesNumber = 0;

    private int[,] capacityMatrix;
    private Dictionary<int, List<int>> neighbors { get; }
    private int sourceNode;
    private int sinkNode;

    public CapacityGraph(int[,] capacityMatrix)
    {
        this.capacityMatrix = capacityMatrix;
        this.neighbors = new Dictionary<int, List<int>>() { };

        // iter over rows
        for (int i = 0; i < capacityMatrix.GetLength(0); i++)
        {
            List<int> neighs = new List<int>();

            // iter over columns
            for (int j = 0; j < capacityMatrix.GetLength(1); j++)
            {
                if (capacityMatrix[i, j] > 0)
                    neighs.Add(j);
            }

            neighbors.Add(i, neighs);   // add to dictionary
        }

        nodesNumber = capacityMatrix.GetLength(0);

        sourceNode = 0;
        sinkNode = 0;
    }

    public int[,] getCapacityMatrix() { return this.capacityMatrix; }

    public Dictionary<int, List<int>> getNeighbors() { return this.neighbors; }

    public int getSourceNode() { return sourceNode; }

    public void setSourceNode(int value)
    {
        if (value >= 0 && value < nodesNumber) sourceNode = value;
    }

    public int getSinkNode() { return sinkNode; }

    public void setSinkNode(int value)
    {
        if (value >= 0 && value < nodesNumber) sinkNode = value;
    }
}
