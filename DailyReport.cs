using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A simple console app to query the user and temporarily store their responses in varaibles. 


class DailyReport
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy \nStudent Daily Report");

        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();

        Console.WriteLine("What page number?");
        string pgNum = Console.ReadLine();
        int pageNumber = Convert.ToInt32(pgNum);

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        string needHelp = Console.ReadLine();
        bool helpRequested = Convert.ToBoolean(needHelp);

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specifc.");
        string miscFeedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        int studyHours = Convert.ToInt32(hoursStudied);

        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
        Console.Read();
    }
}

