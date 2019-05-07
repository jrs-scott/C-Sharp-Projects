using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsAndIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to give input 5 times. Iterate through the input and add it to the empty string array. Then print the results one line at a time to the console.
            Console.WriteLine("Build a sentence by entering one word at a time.");
            string[] buildingArray = new string[5];
            int wordNum = 0;
            foreach (string word in buildingArray)
            {
                Console.WriteLine("Please enter word " + Convert.ToString(wordNum + 1) + ":");
                buildingArray[wordNum] = Console.ReadLine();
                wordNum++;
                if (wordNum == 5)
                {
                    Console.WriteLine("\nYour sentence is:");
                    foreach (string item in buildingArray)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }

            // Create and fix an infinite loop.
            bool terribleLoop = true;
            while (terribleLoop)
            {
                Console.WriteLine("\nSend help! I'm stuck in a loop!");
                terribleLoop = false; // Without changing the condition of the while loop to false, it would keep printing the above text infinitely. 
                Console.WriteLine("... Just kidding, I fixed the infinite loop.");
            }

            // Iterating through a loop using the < operator as the condition to be met.
            Console.WriteLine("\nBased on an array with random numbers, here are the ones under 50: ");
            int[] randomNumbers = { 12, 8, 96, 35, 43 };
            foreach (int number in randomNumbers)
            {
                if (number < 50)
                {
                    Console.Write(number.ToString() + " ");
                }
            }

            // Iterating through a loop using the <= operator as the condition to be met.
            Console.WriteLine("\nThis program counts up to five.");
            int countdown = 1;
            while (countdown <= 5)
            {
                Console.Write(Convert.ToString(countdown) + " ");
                countdown++;
            }

            // Prompts the user select a unqiue item from a string list, and print its corresponding index number. 
            List<string> seasonNames = new List<string>() { "winter", "spring", "summer", "autumn" };
            Console.WriteLine("\nWhat is your favorite season?");
            bool checkInput = true;
            string selectedSeason = Console.ReadLine();
            selectedSeason = selectedSeason.ToLower();
            while (checkInput)
            {
                if (seasonNames.Contains(selectedSeason))
                {
                    Console.WriteLine("The stored index value of your favorite season is " + Convert.ToString(seasonNames.IndexOf(selectedSeason)));
                    checkInput = false;
                }
                else
                {
                    Console.WriteLine("Invalid input - that entry is not on the list. Please enter winter, spring, summer, or autumn:");
                    selectedSeason = Console.ReadLine();
                    selectedSeason = selectedSeason.ToLower();
                }
            }

            // Prompts the user to select a name from the list, then print the indices of the selection.
            List<string> randomNames = new List<string>() { "Bob", "Amy", "Joe", "Mary", "Joe", "Bob" };
            List<int> nameIndexes = new List<int>() { };
            
            Console.WriteLine("\nSelect a name: Bob, Amy, Joe, or Mary:");
            string selectedName = Console.ReadLine();
            while (nameIndexes.Count == 0)
            {
                for (int i = 0; i < randomNames.Count; i++)
                {
                    if (randomNames[i] == selectedName)
                    {
                        nameIndexes.Add(i);
                    }
                }
                if (nameIndexes.Count == 0)
                {
                    Console.WriteLine("Invalid name - Please enter Bob, Amy, Joe, or Mary:");
                    selectedName = Console.ReadLine();
                }
                
            }
            Console.WriteLine("The stored index value(s) of that name are " + String.Join(" ", nameIndexes) );


            // Prompt the user to select from a list. Iterate through the list, and indentify if it's already been listed.
            Console.WriteLine("\nTime to go through the list of names and indentify if it's already been listed in the string.");
            List<string> namesList = new List<string> { };
            foreach (string name in randomNames)
            {
                
                if (namesList.Contains(name))
                {
                    Console.WriteLine(name + " - Has been listed already.");

                }
                else
                {
                    Console.WriteLine(name + " - Has not been listed already.");
                }
                namesList.Add(name);
            }        
            Console.Read();
        }
    }
}
