using Algorithms.Algorithms;
using Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var edges = new List<WeightedEdge>
            {
                new WeightedEdge(0, 1, 1),
                new WeightedEdge(0, 5, 4),
                new WeightedEdge(1, 2, 3),
                new WeightedEdge(1, 4, 1),
                new WeightedEdge(2, 3, 3),
                new WeightedEdge(4, 3, 4),
                new WeightedEdge(4, 5, 1),
                new WeightedEdge(5, 3, 1)
            };
            var start = 0;
            var finish = 3;
            var vertCount = 6;

            var model = new FordBellman(vertCount, edges);
            var result = model.Solve(start, finish);
            Console.WriteLine(result);
        }
    }
}
