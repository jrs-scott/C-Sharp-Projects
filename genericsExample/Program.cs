using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsExample
{
    class Program
    {
        static void Main(string[] args)
        {            
            Employee<string> list1 = new Employee<string>();
            Employee<int> list2 = new Employee<int>();

            list1.Things = new List<string> { "Welcome", "to", "this", "console", "app" };
            list2.Things = new List<int> { 12, 8, 45, 92, 67, 3 };

            Console.WriteLine("The contents of string Things: ");
            foreach (string word in list1.Things)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine("\nThe contents of integer Things: ");
            foreach (int number in list2.Things)
            {
                Console.Write(number + " ");
            }

            Console.Read();
        }
    }
}
