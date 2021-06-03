namespace CodeWars.CodeWars._8kyu
{
    public class StringRepeat
    {
        public static string RepeatStr(int n, string s)
        {
            var result = "";

            for (var i = 0; i < n; i++) result += s;

            return result;
        }
    }
}
