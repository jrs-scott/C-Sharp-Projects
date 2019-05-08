using System;

namespace parameterExample
{
    public class Math
    {
        public static void Multiply(int input, int input2)
        {            
            int result = input * 42; // Execute a math operation on the first input
            Console.WriteLine("{0} x 42 = {1}", input, result);
            Console.WriteLine("The second input you provided was: {0}", input2); // Display the second input provided
        }
    }
}
