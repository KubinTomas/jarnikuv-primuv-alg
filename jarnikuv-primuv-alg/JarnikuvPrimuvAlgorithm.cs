using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarnikuv_primuv_alg
{
    /// <summary>
    /// Jarníkův-Primův algoritmus
    /// slouží pro hledání minimální kostry grafu
    /// </summary>
    class JarnikuvPrimuvAlgorithm
    {
        public Graph GetSkeleton(Graph graph)
        {
            var graphSkeleton = new Graph();

            graphSkeleton.AddVertex(GetRandomStartVertex(graph));

            while (graphSkeleton.Vertexes.Count != graph.Vertexes.Count)
            {
                var edge = GetLowestCostEdgePossibleToAdd(graphSkeleton.Vertexes, graph);
                graphSkeleton.AddEdge(edge);
            }
            
            return graphSkeleton;
        }

        /// <summary>
        /// Dostane list vrcholu, ktere jiz jsou spolu spojeny a hleda ve svych sousedech vrcholy, ktere jsou spojeni s alespon jednim v listu 
        /// a vrati ten s nejmensi vahou hrany
        /// soucasne vytvori hranu mezi nimi
        /// </summary>
        /// <param name="vertexes"></param>
        /// <returns></returns>
        private Edge GetLowestCostEdgePossibleToAdd(List<Vertex> vertexes, Graph graph)
        {
            var usedVertexesNames = vertexes.Select(c => c.Name);
            Edge findedEdge = null;

            vertexes.ForEach(v =>
            {
                var orgV = graph.FindVertex(v.Name);

                var edgesToCheck = new List<Edge>();
                orgV.Edges.ForEach(e =>
                {
                    if(!(usedVertexesNames.Contains(e.V1.Name) && usedVertexesNames.Contains(e.V2.Name)))
                    {
                        edgesToCheck.Add(e);
                    }
                });

                edgesToCheck.ForEach(e =>
                {
                    if(findedEdge == null || e.Weight < findedEdge.Weight)
                    {
                        findedEdge = e;
                    }
                });


            });

            return findedEdge;
        }

        private Vertex GetRandomStartVertex(Graph graph)
        {
            var rnd = new Random();

            //graph.Vertexes.ElementAt(rnd.Next(0, graph.Vertexes.Count));
            var vertex = graph.Vertexes.ElementAt(0);

            return new Vertex(vertex.Name);
        }
    }
}
