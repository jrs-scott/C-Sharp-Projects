using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is {0}. \nPlease enter a number:", DateTime.Now);
            double userNumber = Convert.ToDouble(Console.ReadLine());
            DateTime futureTime = DateTime.Now.AddHours(userNumber);
            Console.WriteLine("In {0} hours, it will be {1}.", userNumber, futureTime);
            Console.Read();

        }
    }
}
