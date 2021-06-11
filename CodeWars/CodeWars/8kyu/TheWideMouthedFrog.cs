namespace CodeWars.CodeWars._8kyu
{
    internal class TheWideMouthedFrog
    {
        public static string MouthSize(string animal)
        {
            return animal.ToLower() == "alligator" ? "small" : "wide";
        }
    }
}