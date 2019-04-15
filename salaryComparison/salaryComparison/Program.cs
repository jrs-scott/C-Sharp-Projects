using System;

namespace salaryComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program \nPlease enter details for Person 1...");
            Console.WriteLine("What is their hourly rate?");
            int person1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours a week do they work?");
            int person1Hours = Convert.ToInt32(Console.ReadLine());
            int person1Weekly = person1Rate * person1Hours;

            Console.WriteLine("Please enter details for Person 2...");
            Console.WriteLine("What is their hourly rate?");
            int person2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours a week do they work?");
            int person2Hours = Convert.ToInt32(Console.ReadLine());
            int person2Weekly = person2Rate * person2Hours;

            Console.WriteLine("Weekly salary of Person 1: \n" + person1Weekly.ToString());
            Console.WriteLine("Weekly salary of Person 2: \n" + person2Weekly.ToString());

            bool comparedSalaries = person1Weekly > person2Weekly;
            Console.WriteLine("Does Person 1 make more than Person 2? \n" + comparedSalaries);
            Console.Read();
        }
    }
}
