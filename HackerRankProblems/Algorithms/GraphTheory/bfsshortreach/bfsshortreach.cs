using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Algorithms.GraphTheory.bfsshortreach
{
    class Solution
    {
        class Edge
        {
            public Edge(int n1, int n2)
            {
                node1 = n1;
                node2 = n2;
            }
            public int node1;
            public int node2;
            public int GetConnectedNode(int n)
            {
                if (node1 == n)
                {
                    return node2;
                }
                if (node2 == n)
                {
                    return node1;
                }
                throw new ArgumentException();
            }
            public override bool Equals(object other)
            {
                Edge o = other as Edge;
                return o.node1 == node1 &&
                    o.node2 == node2;
            }
            public override int GetHashCode()
            {
                return node1 | (node2 << 16);

            }
            public override string ToString()
            {
                return String.Format("[{0},{1}]", node1, node2);
            }
        }


        static void InsertEdge(Dictionary<int, HashSet<Edge>> edges, int node, Edge edge)
        {
            if (edges.ContainsKey(node))
            {
                edges[node].Add(edge);
            }
            else
            {
                edges.Add(node, new HashSet<Edge>() { edge });
            }
        }

        public static void Main(String[] args)
        {


            int numTests = Convert.ToInt32(Console.ReadLine());
            for (int test = 0; test < numTests; test++)
            {
                Dictionary<int, HashSet<Edge>> edges = new Dictionary<int, HashSet<Edge>>();
                var testData = Console.ReadLine().Split(' ')
                    .Select(a => Convert.ToInt32(a)).ToArray();
                int nodeCount = testData[0];
                int edgeCount = testData[1];

                for (int i = 0; i < edgeCount; i++)
                {
                    var edgeData = Console.ReadLine().Split(' ')
                        .Select(a => Convert.ToInt32(a)).ToArray();
                    int n1 = edgeData[0];
                    int n2 = edgeData[1];
                    Edge e = new Edge(edgeData[0], edgeData[1]);
                    InsertEdge(edges, n1, e);
                    InsertEdge(edges, n2, e);
                }
                int startNode = Convert.ToInt32(Console.ReadLine());
                SortedDictionary<int, int> Distances =
                    new SortedDictionary<int, int>();
                for (int i = 0; i < nodeCount; i++)
                {
                    if (i + 1 != startNode)
                    {
                        Distances.Add(i + 1, -1);//assume no connection at the start
                    }
                }
                HashSet<int> Visited = new HashSet<int>();
                Queue<int> BFSQueue = new Queue<int>();
                Visited.Add(startNode);

                int currentWorkingNode = startNode;
                if (edges.ContainsKey(startNode)) 
                    //test if any edge touches the start node.
                    //If not then distances to any other node is -1 according to the rules
                {
                    while (true)
                    {
                        //the Breadth First Search (BFS) algorithm
                        foreach (Edge e in edges[currentWorkingNode])
                        {
                            int n = e.GetConnectedNode(currentWorkingNode);
                            if (!Visited.Contains(n))
                            {
                                BFSQueue.Enqueue(n);
                                Visited.Add(n);
                                if (currentWorkingNode == startNode)
                                {
                                    //if n is a neighbour of the start node, then
                                    //the distance from start to n is 1
                                    Distances[n] = 1;
                                }
                                else
                                {
                                    // from n the distance to the start is the distance of 
                                    // n to the current working node (which is 1) plus the current 
                                    // working node's distance to the start node
                                    Distances[n] = Distances[currentWorkingNode] + 1;
                                }
                            }
                        }
                        if (BFSQueue.Count == 0)
                        {
                            break;
                        }
                        currentWorkingNode = BFSQueue.Dequeue();
                    }
                }

                Console.WriteLine(String.Join(" ", Distances.OrderBy(a => a.Key)
                                              .Select(a => a.Value > 0 ?
                                                      a.Value * 6 : a.Value)));

            }
        }
    }
}
