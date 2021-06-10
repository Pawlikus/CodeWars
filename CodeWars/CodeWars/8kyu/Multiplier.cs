namespace CodeWars.CodeWars._8kyu
{
    internal class Multiplier
    {
        public static int Multiply(int x)
        {
            return x % 2 == 1 ? x * 9 : x * 8;
        }
    }
}