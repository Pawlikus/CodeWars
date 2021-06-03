namespace CodeWars.CodeWars._8kyu
{
    public class CenturyFromYear
    {
        public static int GetСenturyFromYear(int year)
        {
            var result = year / 100;
            if (year % 100 > 0) result++;
            return result;
        }
    }
}