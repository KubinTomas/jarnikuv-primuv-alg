using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarnikuv_primuv_alg
{
    class Graph
    {
        public List<Vertex> Vertexes { get; private set; }
        public List<Edge> Edges { get; private set; }

        public Graph()
        {
            Vertexes = new List<Vertex>();
            Edges = new List<Edge>();
        }

      

        public List<Edge> GetVertexEdges(string name)
        {
            var vertex = FindVertex(name);

            return vertex.Edges;
        }
        public Vertex FindVertex(string name)
        {
            return Vertexes.SingleOrDefault(c => c.Name == name);
        }

        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);
        }
        public void AddVertex(string name)
        {
            var v = new Vertex(name);

            Vertexes.Add(v);
        }

        public void AddEdge(string v1, string v2, int weight = 0)
        {
            AddEdge(FindVertex(v1), FindVertex(v2), weight);
        }

        public void AddEdge(Edge edge)
        {
            var v1 = FindVertex(edge.V1.Name);
            var v2 = FindVertex(edge.V2.Name);

            if (v1 == null) { AddVertex(edge.V1.Name); }
            if (v2 == null) { AddVertex(edge.V2.Name); }

            AddEdge(edge.V1.Name, edge.V2.Name, edge.Weight);
        }


        public void AddEdge(Vertex v1, Vertex v2, int weight = 0)
        {
            var edge = new Edge(v1, v2, weight);

            v1.Edges.Add(edge);
            v2.Edges.Add(edge);

            Edges.Add(edge);
        }

        public string GetInfo()
        {
            var res = string.Empty;

            res += "V: " + Vertexes.Count() + "\n";
            res += string.Join(",", Vertexes.Select(c => c.Name));
            res += "\n";

            res += "E: " + Edges.Count() + "\n";
            res += string.Join(",", Edges.Select(c => c.V1.Name + " - " + c.V2.Name));
            res += "\n";


            return res;
        }
    }
}
