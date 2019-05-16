using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchExample
{
    class Program
    {
        static void Main(string[] args)
        {   
            try
            {
                Console.WriteLine("Please enter your age:");
                int.TryParse(Console.ReadLine(), out int age);
                if (age <= 0)
                {
                    throw new ArgumentException();
                }    
                int birthYear = DateTime.Now.Year - age;
                Console.Write("Unless your birthday is later this year, you were born in {0}.", birthYear);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You entered an invalid input. Please restart the program and try again.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred. Please restart the program and try again.");
            }
            Console.ReadLine();
        }
    }
}
