namespace CodeWars.CodeWars._8kyu
{
    internal class HowOldWillIBeIn2099
    {
        public static string CalculateAge(int birth, int yearTo)
        {
            var age = yearTo - birth;
            if (age == 0) return "You were born this very year!";
            if (age == 1) return "You are 1 year old.";
            if (age == -1) return "You will be born in 1 year.";
            return age > 0 ? "You are " + age + " years old." : "You will be born in " + -age + " years.";
        }
    }
}