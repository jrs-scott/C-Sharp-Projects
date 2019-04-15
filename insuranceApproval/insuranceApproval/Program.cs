using System;

namespace insuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the car insurance approval page. Please enter the follow information...");
            Console.WriteLine("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have? ");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool approval = (age > 15 && dui == false && tickets <= 3);
            Console.WriteLine("Are you qualified? \n" + approval);
            Console.Read();
        }
    }
}