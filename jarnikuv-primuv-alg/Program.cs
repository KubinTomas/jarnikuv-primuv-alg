using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarnikuv_primuv_alg
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = GraphSeed.GetSeed01();

            var skeletonAlg = new JarnikuvPrimuvAlgorithm();

            var graphSkeleton = skeletonAlg.GetSkeleton(graph);


            Console.WriteLine(graph.GetInfo());
            Console.WriteLine("\n"+ "----------");
            Console.WriteLine(graphSkeleton.GetInfo());
        }
    }
}
