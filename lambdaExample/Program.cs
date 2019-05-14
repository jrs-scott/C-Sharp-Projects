using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of ten new employees
            List<Employee> allEmployees = new List<Employee>(); 
            allEmployees.Add(new Employee { FirstName = "Joe", LastName = "Smith", Id = 1 });
            allEmployees.Add(new Employee { FirstName = "Bob", LastName = "Henson", Id = 2 });
            allEmployees.Add(new Employee { FirstName = "Ned", LastName = "Flanders", Id = 3 });
            allEmployees.Add(new Employee { FirstName = "Joe", LastName = "Anderson", Id = 4 });
            allEmployees.Add(new Employee { FirstName = "Mary", LastName = "Wells", Id = 5 });
            allEmployees.Add(new Employee { FirstName = "Sue", LastName = "Jones", Id = 6 });
            allEmployees.Add(new Employee { FirstName = "Amy", LastName = "Sanders", Id = 7 });
            allEmployees.Add(new Employee { FirstName = "Joel", LastName = "Delp", Id = 8 });
            allEmployees.Add(new Employee { FirstName = "Joe", LastName = "Baldwin", Id = 9 });
            allEmployees.Add(new Employee { FirstName = "Larry", LastName = "Johnson", Id = 10 });

            // Using a for each loop to populate a new list of all employees with the first name Joe
            List<Employee> employeeJoe = new List<Employee>(); 
            foreach (Employee person in allEmployees)
            {                
                if (person.FirstName == "Joe")
                {
                    employeeJoe.Add(person);
                }
            }

            // Using a lambda function to create a new list of all employees with the first name Joe, then writing their names to the console
            List<Employee> firstNameJoe = allEmployees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("All employees with the first name Joe:");
            firstNameJoe.ForEach(i => Console.WriteLine("\t{0} {1}", i.FirstName, i.LastName));

            // Using a lambda function to create a new list of all employee with an ID greater than 5, then writing their names to the console
            List<Employee> selectedIds = allEmployees.Where(x => x.Id > 5).ToList(); 
            Console.WriteLine("\nAll employees with an ID greater than 5:");
            selectedIds.ForEach(i => Console.WriteLine("\t{0} {1}", i.FirstName, i.LastName));           

            Console.Read();
        }
    }
}
