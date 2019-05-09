using System;

namespace simpleClass
{
    public class Math
    {
        public static void Divide(int dividend, out int total)
        {
            total = dividend / 2;
        }

        public static void Divide(int dividend, int divisor, out int total)
        {
            total = dividend / divisor;
        }
    }
}
