using System.Collections.Generic;
using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    internal class LarioAndMuigiPipeProblem
    {
        public static List<int> PipeFix(List<int> numbers)
        {
            return Enumerable.Range(numbers.Min(), numbers.Max() - numbers.Min() + 1).ToList();
        }
    }
}