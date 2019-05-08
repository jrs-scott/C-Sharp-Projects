using System;

namespace parameterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Math math = new Math(); // Instantiate the class
            Math.Multiply(input, input2); // Pass in two numbers
            Math.Multiply(input: 5, input2: 10); // Pass in two numbers, specifying the parameters by name

            Console.Read();
        }
    }
}
