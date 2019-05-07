using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Let's do some division. Enter a number:");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                List<int> numbers = new List<int> { 12, 65, 92, 43, 70 };
                foreach (int num in numbers)
                {
                    Console.WriteLine(num + " divided by " + inputNumber + " equals: " + (num / inputNumber));
                }                    
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter an integer.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero.");
            }
            finally
            {
                Console.WriteLine("The program has come to an end.");
            }
            Console.Read();
        }
    }
}
