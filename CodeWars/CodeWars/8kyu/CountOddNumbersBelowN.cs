namespace CodeWars.CodeWars._8kyu
{
    internal class CountOddNumbersBelowN
    {
        public static ulong OddCount(ulong n)
        {
            return n % 2 == 1 ? (n - 1) / 2 : n / 2;
        }
    }
}