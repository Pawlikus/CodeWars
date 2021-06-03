namespace CodeWars.CodeWars._8kyu
{
    public class AbbreviateTwoWordName
    {
        public static string AbbrevName(string name)
        {
            return string.Concat(name[0].ToString().ToUpper() + "." + name[name.IndexOf(" ") + 1].ToString().ToUpper());
        }
    }
}