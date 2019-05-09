using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a whole number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a second number. Otherwise, press enter: ");
                string input = Console.ReadLine();
                Math math = new Math();
                if (input != "")
                {
                    int number2 = Convert.ToInt32(input);
                    int total = Math.Add(number1, number2);
                    Console.WriteLine("{0} + 50 + {1} = {2}", number1, number2, total);
                }
                else
                {
                    int total = Math.Add(number1);
                    Console.WriteLine("{0} + 50 = {1}", number1, total);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
