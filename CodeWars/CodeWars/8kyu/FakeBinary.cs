namespace CodeWars.CodeWars._8kyu
{
    public class FakeBinary
    {
        public static string FakeBin(string x)
        {
            var result = "";
            foreach (var c in x)
                if (c < '5') result += "0";
                else result += "1";

            return result;
        }
    }
}