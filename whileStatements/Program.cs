using System;

namespace whileStatements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("True or false - you would like a cookie:");
            bool giveCookie = Convert.ToBoolean(Console.ReadLine());
            int cookieCount = 0;
            do
            {
                switch (giveCookie)
                {
                    case true:
                        Console.WriteLine("Great! Here is a delicious cookie for you.");
                        cookieCount++;
                        Console.WriteLine("\nTrue or false - you would like a cookie:");
                        giveCookie = Convert.ToBoolean(Console.ReadLine());                       
                        break;
                    default:
                        Console.WriteLine("Oh, okay. No cookies for you then.");
                        break;   
                }
            }
            while (giveCookie);
            Console.WriteLine("You have " + Convert.ToString(cookieCount) + " cookies!");
            while (cookieCount == 0)
            {
                Console.WriteLine("Come see us when you'd like some cookies.");
                cookieCount++;
            }
            Console.Read();
        }
    }
}
