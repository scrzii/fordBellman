using Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Algorithms
{
    public class FordBellman
    {
        private readonly int _vertexCount;
        private readonly IEnumerable<WeightedEdge> _edges;

        public FordBellman(int vertexCount, IEnumerable<WeightedEdge> edges)
        {
            _vertexCount = vertexCount;
            _edges = edges;
        }

        public int Solve(int start, int finish, bool undirected = false)
        {
            var disntances = Enumerable.Range(0, _vertexCount)
                .Select(x => int.MaxValue)
                .ToList();

            disntances[start] = 0;

            for (int i = 0; i < _vertexCount; i++)
            {
                foreach (var edge in _edges)
                {
                    disntances[edge.To] = Math.Min(disntances[edge.To], disntances[edge.From] + edge.Weight);
                    if (undirected)
                    {
                        disntances[edge.From] = Math.Min(disntances[edge.From], disntances[edge.To] + edge.Weight);
                    }
                }
            }

            var result = disntances[finish];
            if (result == int.MaxValue)
            {
                throw new Exception($"Путь до вершины {finish} не найден");
            }
            return result;
        }
    }
}
