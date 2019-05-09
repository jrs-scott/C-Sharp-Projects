using System;

namespace simpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be divided: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Math math = new Math();
            int total = 0;
            Math.Divide(dividend, out total);
            Console.WriteLine("{0} / 2 = {1}", dividend, total);

            Console.WriteLine("Please enter a number to be divided: ");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number to divide by: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Math.Divide(dividend, divisor, out total);
            Console.WriteLine("{0} / {1} = {2}", dividend, divisor, total);

            Console.Read();
        }
    }
}
