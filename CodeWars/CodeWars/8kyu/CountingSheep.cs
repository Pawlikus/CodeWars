using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    public class CountingSheep
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(s => s);
        }
    }
}