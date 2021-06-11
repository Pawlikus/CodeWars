namespace CodeWars.CodeWars._8kyu
{
    internal class AreYouPlayingBanjo
    {
        public static string AreYouPlayingBanjoo(string name)
        {
            if (name[0] == 'r') return name + " plays banjo";
            if (name[0] == 'R') return name + " plays banjo";
            else return name + " does not play banjo";
        }
    }
}