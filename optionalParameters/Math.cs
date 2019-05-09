using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParameters
{
    public class Math
    {
        public static int Add(int number1, int number2 = 0)
        {
            int total = number1 + 50 + number2;
            return total;
        }
    }
}
