using System;

namespace methodsExample
{
    public class Math
    {
        public static void Add(int input)
        {            
            int value = input + 50;
            Console.WriteLine(input + " + 50 = " + value);
        }
        public static void Divide(int input)
        {
            int value = input / 10;
            Console.WriteLine(input + " / 10 = " + value);
        }
        public static void Multiply(int input)
        {
            int value = input * 2;
            Console.WriteLine(input + " x 2 = " + value);
        }
    }
}
