using System;

namespace parameterExample
{
    public class Math
    {
        public static void Calculate(int input)
        {
            int value = input * 2;
            Console.WriteLine("Int to int... {0} x 2 = {1}", input, value);
        }

        public static void Calculate(decimal input)
        {
            int value2 = Decimal.ToInt32(input + 10);
            Console.WriteLine("Decimal to int... {0} + 10 = {1}", input, value2);
        }

        public static void Calculate(string input)
        {
            int value3 = Convert.ToInt32(input) - 2;
            Console.WriteLine("String to int... {0} - 2 = {1}", input, value3);
        }
    }
}
