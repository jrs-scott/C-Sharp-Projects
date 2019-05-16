using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill162
{
    class Program
    {
        static void Main(string[] args)
        {            
            const string constantName = "This string is a constant."; // 1) Create a constant variable
            var num = 42; // 2) Use the "var" keyword in a new variable
            Person newPerson = new Person("John");
            Console.WriteLine("{0}\nThe integer value is {1}.\n{2} is a new Person.", constantName, num, newPerson.FirstName);
            Console.Read();
        }
    }
    public class Person
    {
        public Person(string fName) : this(fName, "", 00) // 3) Chain two constructors together
        {
        }
        public Person(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
