using System;

namespace mathOperators
{
    class Program
    {
        static void Main()
        {
            Console.Write("Welcome to the math operator terminal. \nPlease enter a whole number: ");
            string input1 = Console.ReadLine();
            int userNumber = Convert.ToInt32(input1);
            int multipliedNumber = userNumber * 50;
            Console.WriteLine("Your number multiplied by 50 = " + multipliedNumber.ToString());

            Console.Write("\nPlease enter another whole number: ");
            string input2 = Console.ReadLine();
            int userNumber2 = Convert.ToInt32(input2);
            int addedNumber = userNumber2 + 25;
            Console.WriteLine("Your number plus 25 = " + addedNumber.ToString());

            Console.Write("\nPlease enter a third whole number: ");
            string input3 = Console.ReadLine();
            int userNumber3 = Convert.ToInt32(input3);
            double dividedNumber = userNumber3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + dividedNumber.ToString());

            Console.Write("\nPlease enter a fourth whole number: ");
            string input4 = Console.ReadLine();
            int userNumber4 = Convert.ToInt32(input4);
            bool comparedNumber = userNumber4 > 50;
            Console.WriteLine("Is your number greater than 50? " + comparedNumber.ToString());

            Console.Write("\nPlease enter a final whole number: ");
            string input5 = Console.ReadLine();
            int userNumber5 = Convert.ToInt32(input5);
            int remainderNumber = userNumber5 % 7;
            Console.WriteLine("After dividing your number by 7, the remainder left is: " + remainderNumber.ToString());

            Console.WriteLine("\nI hope you enjoyed doing math together! See you next time.");
            Console.Read();
        }
    }
}
