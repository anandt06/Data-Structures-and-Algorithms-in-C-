using System;
using System.Collections.Generic;

namespace DSA.DataStructures.Graph
{
    public class Graph
    {
        private readonly Dictionary<int, List<int>> _adjacencyList;

        public Graph()
        {
            _adjacencyList = new Dictionary<int, List<int>>();
        }

        // Add a new vertex to the graph
        public void AddVertex(int vertex)
        {
            if (!_adjacencyList.ContainsKey(vertex))
            {
                _adjacencyList[vertex] = new List<int>();
            }
        }

        // Add an edge between two vertices
        public void AddEdge(int vertex1, int vertex2)
        {
            if (!_adjacencyList.ContainsKey(vertex1))
            {
                AddVertex(vertex1);
            }

            if (!_adjacencyList.ContainsKey(vertex2))
            {
                AddVertex(vertex2);
            }

            _adjacencyList[vertex1].Add(vertex2);
            _adjacencyList[vertex2].Add(vertex1); // For undirected graph
        }

        // Get all vertices connected to a given vertex
        public IEnumerable<int> GetAdjacentVertices(int vertex)
        {
            if (_adjacencyList.ContainsKey(vertex))
            {
                return _adjacencyList[vertex];
            }

            return new List<int>();
        }

        // Display the graph
        public void DisplayGraph()
        {
            foreach (var vertex in _adjacencyList)
            {
                Console.Write($"{vertex.Key}: ");

                foreach (var adjacentVertex in vertex.Value)
                {
                    Console.Write($"{adjacentVertex} ");
                }

                Console.WriteLine();
            }
        }

        // Breadth-First Search (BFS) from a given vertex
        public void BFS(int startVertex)
        {
            var visited = new HashSet<int>();
            var queue = new Queue<int>();

            visited.Add(startVertex);
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                var currentVertex = queue.Dequeue();
                Console.Write($"{currentVertex} ");

                foreach (var neighbor in GetAdjacentVertices(currentVertex))
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            Console.WriteLine();
        }

        // Depth-First Search (DFS) from a given vertex
        public void DFS(int startVertex)
        {
            var visited = new HashSet<int>();
            DFSRecursive(startVertex, visited);
            Console.WriteLine();
        }

        private void DFSRecursive(int vertex, HashSet<int> visited)
        {
            visited.Add(vertex);
            Console.Write($"{vertex} ");

            foreach (var neighbor in GetAdjacentVertices(vertex))
            {
                if (!visited.Contains(neighbor))
                {
                    DFSRecursive(neighbor, visited);
                }
            }
        }
    }

    class GraphProgram
    {
        static void Main(string[] args)
        {
            var graph = new Graph();

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            Console.WriteLine("Graph adjacency list:");
            graph.DisplayGraph();

            Console.WriteLine("\nBFS traversal starting from vertex 0:");
            graph.BFS(0);

            Console.WriteLine("DFS traversal starting from vertex 0:");
            graph.DFS(0);
        }
    }

}