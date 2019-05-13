using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A short coding example of overloading an operator.");
            Employee employee = new Employee() { FirstName = "Bob", LastName = "Smith", Id = 1 };
            Employee employee2 = new Employee() { FirstName = "John", LastName = "Doe", Id = 2 };

            Console.WriteLine("{0} and {1} have the same ID number: {2}", (employee.FirstName), (employee2.FirstName), (employee == employee2));

            Console.Read();
        }
    }
}
