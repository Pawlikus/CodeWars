namespace CodeWars.CodeWars._8kyu
{
    internal class IfYouCantSleepJustCountSheep
    {
        public static string CountSheep(int n)
        {
            var result = "";
            for (var i = 1; i <= n; i++) result += $"{i} sheep...";
            return result;
        }
    }
}