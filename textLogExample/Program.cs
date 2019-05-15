using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace textLogExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\Jamie\Desktop\log.txt", true))
            {
                file.WriteLine(userInput);
            }
            Console.WriteLine("Your number has been logged. Thank you!");
            Console.Read();
        }
    }
}
