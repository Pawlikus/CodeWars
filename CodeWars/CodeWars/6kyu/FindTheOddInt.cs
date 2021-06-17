using System.Linq;

namespace CodeWars.CodeWars._6kyu
{
    internal class FindTheOddInt
    {
        public static int find_it(int[] seq)
        {
            return seq.GroupBy(x => x)
                .Where(x => x.Count() % 2 != 0)
                .Select(x => x.First())
                .FirstOrDefault();
        }
    }
}