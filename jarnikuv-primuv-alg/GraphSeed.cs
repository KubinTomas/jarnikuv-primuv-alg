using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarnikuv_primuv_alg
{
    class GraphSeed
    {
        public static Graph GetSeed01()
        {
            var graph = new Graph();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddVertex("E");


            graph.AddEdge("A", "B", 2);
            graph.AddEdge("A", "E", 5);
            graph.AddEdge("A", "D", 6);
            graph.AddEdge("A", "C", 2);

            graph.AddEdge("C", "D", 3);

            graph.AddEdge("D", "E", 1);

            return graph;
        }

        public static Graph GetSeed02()
        {
            var graph = new Graph();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddVertex("E");
            graph.AddVertex("F");
            graph.AddVertex("G");

            graph.AddEdge("A", "B", 7);
            graph.AddEdge("A", "D", 5);
            graph.AddEdge("B", "C", 8);
            graph.AddEdge("B", "E", 7);
            graph.AddEdge("B", "D", 9);
            graph.AddEdge("C", "E", 5);
            graph.AddEdge("D", "E", 15);
            graph.AddEdge("D", "F", 6);
            graph.AddEdge("E", "G", 9);
            graph.AddEdge("E", "F", 8);
            graph.AddEdge("F", "G", 11);

            return graph;
        }

    }
}
