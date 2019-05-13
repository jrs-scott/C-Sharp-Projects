using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloadExample
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public static bool operator ==(Employee a, Employee b)
        {
            return a.Id.Equals(b.Id);
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return !a.Id.Equals(b.Id);
        }
    }
}
