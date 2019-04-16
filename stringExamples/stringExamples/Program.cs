using System;
using System.Text;

namespace stringExamples
{
    class Program
    {
        static void Main()
        {
            // Concatenating three string
            string s1 = "Why ";
            string s2 = "hello ";
            string s3 = "there!";
            Console.WriteLine(s1 + s2 + s3);

            // Converting a string to uppercase
            string s4 = "this started out as a quiet sentence.";
            Console.WriteLine(s4.ToUpper());

            // Building a paragraph of text, one sentance at a time
            StringBuilder sb = new StringBuilder();
            sb.Append("Welcome to an example of strings.");
            sb.Append(" They are an icredibily helpful data type used in many programming languages.");
            sb.Append(" Depending on what your goal is, you can really get creative!");
            sb.Append(" Here is a clunky example of how to create add to a string using StringBuilder.");
            Console.WriteLine(sb);

            Console.Read();
        }
    }
}
