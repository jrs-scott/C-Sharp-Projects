using System;

namespace enumExample
{
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the current day of the week: ");
            string userInput = Console.ReadLine();
            try 
            {
                DaysOfTheWeek currentDay = (DaysOfTheWeek) Enum.Parse(typeof(DaysOfTheWeek), userInput, true);
                Console.WriteLine("\nToday is {0}.", currentDay);                                              
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.Read();
            }                     
        }
    }
}
