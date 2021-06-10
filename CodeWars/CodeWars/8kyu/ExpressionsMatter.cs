using System.Collections.Generic;
using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    internal class ExpressionsMatter
    {
        public static int ExpressionMatter(int a, int b, int c)
        {
            var results = new List<int>();
            results.Add(a * (b + c));
            results.Add(a * b * c);
            results.Add(a + b * c);
            results.Add((a + b) * c);
            results.Add(a + b + c);
            results.Add(a * b + c);
            return results.Max();
        }
    }
}