namespace CodeWars.CodeWars._8kyu
{
    internal class LeonadroDicaprioAndOscars
    {
        public static string Leo(int oscar)
        {
            switch (oscar)
            {
                case 88:
                    return "Leo finally won the oscar! Leo is happy";

                case 86:
                    return "Not even for Wolf of wallstreet?!";
            }

            return oscar < 88 ? "When will you give Leo an Oscar?" : "Leo got one already!";
        }
    }
}