using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarnikuv_primuv_alg
{
    class Edge
    {
        public Vertex V1 { get; set; }  
        public Vertex V2 { get; set; }
        public int Weight { get; set; }

        public Edge(Vertex v1, Vertex v2, int weight = 0)
        {
            V1 = v1;
            V2 = v2;
            Weight = weight;
        }

        public Vertex GetEndVertex(Vertex startVertex)
        {
            return V1.Name == startVertex.Name ? V2 : V1;
        }

        public bool ContainsVertex(string name)
        {
            return V1.Name == name || V2.Name == name;
        }
    }
}
