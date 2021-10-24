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
     
    }
}
