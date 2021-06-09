using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    internal class SumMixedArray
    {
        public static int SumMix(object[] x)
        {
            return x.Sum(n => int.Parse(n.ToString()));
        }
    }
}