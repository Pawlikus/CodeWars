using System;

namespace CodeWars.CodeWars._8kyu
{
    internal class SwitchCaseBugFixing6
    {
        public static double EvalObject(double value1, double value2, char operation)
        {
            double result = 0;
            switch (operation)
            {
                case '+': return result = value1 + value2;
                case '-': return result = value1 - value2;
                case '/': return result = value1 / value2;
                case '*': return result = value1 * value2;
                case '%': return result = value1 % value2;
                case '^': return result = Math.Pow(value1, value2);
                default: return 0;
            }
        }
    }
}