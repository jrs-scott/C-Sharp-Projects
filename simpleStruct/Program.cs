using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleStruct
{
    public struct Number
    {
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Number testNumber = new Number { Amount = 12.45m };
            Console.WriteLine("The stored amount is: {0}", Convert.ToString(testNumber.Amount));
            Console.Read();
        }
    }
}
