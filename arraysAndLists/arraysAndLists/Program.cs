using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prompt the user to select an index number, and print the corresponding value given the string array
        string[] stringArray = { "Hello", "Privyet", "Hola", "Bonjour", "Hallo" };
        Console.WriteLine("Please enter a number between 0 and 4:"); 
        bool checkInput = true;
        while (checkInput)
        {
            try
            {                                
                int input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You selected " + input1 + ". The value stored at that index is: " + stringArray[input1]);
                checkInput = false;
            }
            catch
            {
                Console.WriteLine("Invalid input. Please only enter 0, 1, 2, 3, or 4:");
            }
        }

        // Prompt the user to select an index number, and print the corresponding value given the integer array
        int[] numArray = { 34, 81, 42, 60, 59 };
        Console.WriteLine("\nPlease enter a number between 0 and 4:");
        bool checkInput2 = true;
        while (checkInput2)
        {
            try
            {
                int input2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You selected " + input2 + ". The value stored at that index is: " + numArray[input2]);
                checkInput2 = false;
            }
            catch
            {
                Console.WriteLine("Invalid input. Please only enter 0, 1, 2, 3, or 4:");
            }
        }

        // Prompt the user to select an index number, and print the corresponding value given the string list
        List<string> myList = new List<string>();
        myList.Add("Red");
        myList.Add("Green");
        myList.Add("Blue");
        myList.Add("Yellow");
        myList.Add("Purple");
        Console.WriteLine("\nPlease enter a number between 0 and 4:");
        bool checkInput3 = true;
        while (checkInput3)
        {
            try
            {
                int input3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You selected " + input3 + ". The value stored at that index is: " + myList[input3]);
                checkInput3 = false;
            }
            catch
            {
                Console.WriteLine("Invalid input. Please only enter 0, 1, 2, 3, or 4:");
            }
        }
        Console.Read();
    }
}

