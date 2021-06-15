namespace CodeWars.CodeWars._8kyu
{
    internal class GrasshopperPersonalizedMessage
    {
        public static string Greet(string name, string owner)
        {
            return name == owner ? "Hello boss" : "Hello guest";
        }
    }
}