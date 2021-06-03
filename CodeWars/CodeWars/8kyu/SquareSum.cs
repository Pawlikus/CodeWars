using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    public class SquareSum
    {
        public static int SquareSumArray(int[] n)
        {
            return n.Sum(s => s * s);
        }
    }
}