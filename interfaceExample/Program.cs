using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            IQuittable quittable = new Employee();

            Console.WriteLine("Welcome to the employee database. Please enter a first name:");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter a last name:");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("\nHere is the information you entered...");
            employee.SayName();
            quittable.Quit();

            Console.Read();
        }
    }
}
