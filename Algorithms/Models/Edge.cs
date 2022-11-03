using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Models
{
    public class Edge
    {
        public int From { get; set; }
        public int To { get; set; }
    }

    public class WeightedEdge : Edge
    {
        public int Weight { get; set; }

        public WeightedEdge(int from, int to, int weight)
        {
            From = from;
            To = to;
            Weight = weight;
        }
    }
}
