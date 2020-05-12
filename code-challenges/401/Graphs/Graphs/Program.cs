using Graphs.Classes;
using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>();
            var a = graph.AddNode("Pandora");
            var b = graph.AddNode("Arendelle");
            var c = graph.AddNode("Metroville");
            var d = graph.AddNode("Monstropolis");
            var e = graph.AddNode("Narnia");
            var f = graph.AddNode("Naboo");
            graph.AddEdge(a, b, 1);
            graph.AddEdge(b, c, 1);
            graph.AddEdge(b, d, 1);
            graph.AddEdge(c, d, 1);
            graph.AddEdge(c, e, 1);
            graph.AddEdge(c, f, 1);
            graph.AddEdge(d, f, 1);
            graph.AddEdge(e, f, 1);

            var result = graph.BreadthFirst(a);

            foreach(var node in result)
            {
                Console.WriteLine(node.Value);
            }

        }
    }
}
