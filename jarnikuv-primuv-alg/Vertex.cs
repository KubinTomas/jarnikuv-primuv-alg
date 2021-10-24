using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarnikuv_primuv_alg
{
    class Vertex
    {
        public string Name { get; set; }
        public List<Edge> Edges { get; set; }

        public Vertex(string name)
        {
            Name = name;
            Edges = new List<Edge>();
        }
    }
}
