using System;

namespace packageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \nPlease enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50) {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            int totalSize = packageWidth + packageHeight + packageLength;
            if (totalSize > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else if (totalSize <= 50)
            {
                decimal quote = (totalSize * packageWeight) / 100m;
                Console.WriteLine("Your estimated total for shipping this package is: {0:C2}\nThank you.", quote);
            }            
            Console.Read();
        }
    }
}