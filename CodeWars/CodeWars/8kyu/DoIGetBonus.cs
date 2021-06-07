namespace CodeWars.CodeWars._8kyu
{
    internal class DoIGetBonus
    {
        public static string bonus_time(int salary, bool bonus)
        {
            return bonus ? "$" + salary * 10 : "$" + salary;
        }
    }
}