using System.Linq;

namespace CodeWars.CodeWars._6kyu
{
    internal class MultiplesOf3Or5
    {
        public static int Solution(int value)
        {
            return Enumerable.Range(0, value)
                .Where(x => x % 3 == 0 || x % 5 == 0)
                .Sum();
        }
    }
}