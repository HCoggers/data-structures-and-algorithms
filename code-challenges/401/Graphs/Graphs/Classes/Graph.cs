using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph<T>
    {

        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
        private int _size;

        /// <summary>
        /// Class Constructor creates new Adjacency List
        /// </summary>
        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        /// <summary>
        /// Adds a new value to the Graph
        /// </summary>
        /// <param name="value">value to be added</param>
        /// <returns>Node containing given value</returns>
        public Vertex<T> AddNode(T value)
        {
            Vertex<T> node = new Vertex<T>(value);
            AdjacencyList.Add(node, new List<Edge<T>>());
            _size++;
            return node;
        }

        /// <summary>
        /// Add Edge from vertex a to vertex b, and set a weight
        /// </summary>
        /// <param name="a">starting vertex</param>
        /// <param name="b">connecting vertex</param>
        /// <param name="weight">weigh of edge</param>
        /// <returns>created edge</returns>
        public Edge<T> AddEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            Edge<T> edge = new Edge<T>
            {
                Vertex = b,
                Weight = weight
            };
            AdjacencyList[a].Add(edge);
            return edge;
        }

        /// <summary>
        /// Retrieves all nodes in the graph
        /// </summary>
        /// <returns>a list of nodes</returns>
        public List<Vertex<T>> GetAllNodes()
        {
            List<Vertex<T>> nodes = new List<Vertex<T>>();

            foreach (var vertex in AdjacencyList)
            {
                nodes.Add(vertex.Key);
            }

            if (nodes.Count == 0)
                return null;
            else
                return nodes;
        }

        /// <summary>
        /// Gets all the connecting branches of a specified node
        /// </summary>
        /// <param name="node">node to find neighbors</param>
        /// <returns>a list of edges connected to that node</returns>
        public List<Edge<T>> GetNeighbors(Vertex<T> node)
        {
            return AdjacencyList[node];
        }

        public int Size()
        {
            return _size;
        }
    }
}
