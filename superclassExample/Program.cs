using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superclassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A short coding example using a superclass method.");
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.Read();
        }
    }
}
