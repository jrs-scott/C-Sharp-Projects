using System;

namespace methodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a whole number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                Math.Add(input);
                Math.Divide(input);
                Math.Multiply(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }        
    }
}
