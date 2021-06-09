using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    internal class CountByX
    {
        public static int[] CountBy(int x, int n)
        {
            int[] z = { };
            z = Enumerable.Range(1, n).Select(i => i * x).ToArray();
            return z;
        }
    }
}