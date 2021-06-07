namespace CodeWars.CodeWars._8kyu
{
    internal class BeginnerReduceButGrow
    {
        public static int Grow(int[] x)
        {
            var result = 1;

            foreach (var number in x) result *= number;

            return result;
        }
    }
}