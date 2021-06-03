using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    public class BeginnerLostWithoutMap
    {
        public static int[] Maps(int[] x)
        {
            return x.Select(n => n * n).ToArray();
        }
    }
}