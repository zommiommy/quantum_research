using System;
using System.Collections.Generic; 

/**
 * This version of the Max Flow Analisys does not use a quantum search,
 * but just a classical function
 */
 
/// Edmonds Karp MaxFlow Algorithm
/// based on en.wikipedia.org/wiki/Edmonds%E2%80%93Karp_algorithm
public static class EdmondsKarp
{

    ///  Overloaded method with no initial flow
    public static int FindMaxFlow(
        int[,] capacityMatrix,
        Dictionary<int, List<int>> neighbors,
        int source,
        int sink)
    {
        int n = capacityMatrix.GetLength(0);
        int[,] legalFlows = new int[n, n];  // initialized with zero initial flow

        return FindMaxFlow(capacityMatrix, neighbors, source, sink, legalFlows);
    }


    public static int FindMaxFlow(
        int[,] capacityMatrix,
        Dictionary<int, List<int>> neighbors,
        int source,
        int sink,
        int[,] legalFlows)
    {
        int n = capacityMatrix.GetLength(0);

        // defining the residual graph with al 0
        int[,] residualGraph = new int[n, n];

        // initializing the residual graph with the given flows
        for (int u=0; u<n; u++)
            for (int v=0; v<n; v++)
                residualGraph[u, v] = capacityMatrix[u, v] - legalFlows[u, v];


        int f = 0; // initial flow is 0

        while (true)
        {
            int[] p;
            int m = BreadthFirstSearch(capacityMatrix, neighbors, source, sink, residualGraph, out p);

            if (m == 0) break;
            f += m;
            // backtrack search, and write flow
            int v = sink;

            while (v != source)
            {
                int u = p[v];
                residualGraph[u, v] -= m;
                residualGraph[v, u] += m;
                v = u;
            }

        }

        return f;
    }
    

    private static int BreadthFirstSearch(
        int[,] capacityMatrix,
        Dictionary<int, List<int>> neighbors,
        int source,
        int sink,
        int[,] residualGraph,
        out int[] p)
    {
        int n = capacityMatrix.GetLength(0);

        p = new int[n];                                     // an array of predecessors taken to get to each vertex
        for (int i = 0; i < n; i++) { p[i] = -1; }          // initialization of the array
        p[source] = -2;                                     // make sure source is not rediscovered

        int[] m = new int[n];                               // capacity of found path to node
        m[source] = int.MaxValue;                           // initialize source capacity with infinity

        Queue<int> q = new Queue<int>();                    // a queue
        q.Enqueue(source);                                  // put source node in the queue

        while (q.Count > 0)
        {
            int u = q.Dequeue();

            // classical function to get neighbors not seen yet - to be substituted with QUANTUM function
            List<int> unseenNeighbors = GetUnseenNeighbors(neighbors, residualGraph, u, p);

            foreach (int v in unseenNeighbors)
            {
                p[v] = u;
                m[v] = Math.Min(m[u], residualGraph[u, v]);

                if (v != sink) q.Enqueue(v);
                else return m[sink];
            }

        }

        return 0;

    }

    private static List<int> GetUnseenNeighbors(
        Dictionary<int, List<int>> neighbors,
        int[,] residualGraph,
        int u,
        int[] p)
    {
        List<int> unseenNeighbors = new List<int>();

        foreach (int v in neighbors[u])
        {
            // if there is available capacity, and v is not seen before in search
            if (residualGraph[u, v] > 0 && p[v] == -1)
            {
                unseenNeighbors.Add(v);
            }
        }

        return unseenNeighbors;
    }
}