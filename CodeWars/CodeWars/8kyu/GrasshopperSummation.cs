namespace CodeWars.CodeWars._8kyu
{
    public class GrasshopperSummation
    {
        public static int Summation(int num)
        {
            var sum = 0;
            for (var i = 1; i <= num; i++) sum = sum + i;
            return sum;
        }
    }
}