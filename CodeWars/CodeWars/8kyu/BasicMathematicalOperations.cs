using System;

namespace CodeWars.CodeWars._8kyu
{
    internal class BasicMathematicalOperations
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '+':
                    return value1 + value2;

                case '-':
                    return value1 - value2;

                case '*':
                    return value1 * value2;

                case '/':
                    return value1 / value2;

                default:
                    throw new ArgumentException("Unknown operation:", operation.ToString());
            }
        }
    }
}