using System;

namespace parameterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No user input required. Here are a few math operations.");

            Math mathInt = new Math();
            Math.Calculate(12);

            Math mathDec = new Math();
            Math.Calculate(5.6m);

            Math mathString = new Math();
            Math.Calculate("8");

            Console.Read();
        }
    }
}
