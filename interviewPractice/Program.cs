using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Given an array of integers write a method to total the odd numbers
            int TotalOddInts(int[] inputArray)
            {
                int total = 0;           
                foreach (int i in inputArray)
                {
                    if (i % 2 != 0) total += i;
                }
                if (total == 0) Console.WriteLine("There were no odd integers in the array.");
                else Console.WriteLine("Given an integer array, the odd numbers total: {0}", total.ToString());
                return total;
            }

            int[] randomArray = { 0, 5, 2, 19 };
            TotalOddInts(randomArray);


            // 2) Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers
            long SumIntArray(int[] inputArray)
            {
                long intSum = 0;
                foreach (int i in inputArray)
                {                    
                    intSum += i;
                }
                Console.WriteLine("The sum of integers in the array is: {0}", intSum);
                return intSum;
            }

            int[] randomArray2 = { 907862859, 423, 76, 4, 994078302, 594055786 };
            SumIntArray(randomArray2);


            // 3) Given a string, reverse it
            string Reverse(string inputString)
            {
                char[] characterArray = inputString.ToCharArray();
                Array.Reverse(characterArray);
                return new string(characterArray);
            }
            Console.WriteLine(Reverse("Here is an example sentence."));


            // 4) Given a string, remove any repeated letters
            string NoDuplicates(string inputString)
            {
                var unqiueString = inputString.Distinct().ToArray();
                return new string(unqiueString);
            }

            Console.WriteLine(NoDuplicates("Testing to see if this removes duplicated letters..."));


            // 5) Provide to a solution to the FizzBuzz question
            var fizzBuzz = Enumerable.Range(1, 100);

            foreach (int x in fizzBuzz)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }

            Console.Read();
        }
    }
}
