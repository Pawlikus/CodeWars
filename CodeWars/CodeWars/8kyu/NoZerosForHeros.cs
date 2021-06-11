namespace CodeWars.CodeWars._8kyu
{
    internal class NoZerosForHeros
    {
        public static int NoBoringZeros(int n)
        {
            return n == 0 ? 0 : int.Parse(n.ToString().TrimEnd('0'));
        }
    }
}