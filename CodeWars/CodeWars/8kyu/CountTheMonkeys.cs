using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    internal class CountTheMonkeys
    {
        public static int[] MonkeyCount(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }
    }
}