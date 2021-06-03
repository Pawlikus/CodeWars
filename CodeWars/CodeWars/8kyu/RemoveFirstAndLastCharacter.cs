namespace CodeWars.CodeWars._8kyu
{
    public class RemoveFirstAndLastCharacter
    {
        public static string Remove_char(string s)
        {
            return s.Substring(1, s.Length - 2);
        }
    }
}
