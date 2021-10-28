using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOpsUsingMethods
{
    class Operation
    {
        // Takes an integer and adds 2 to it then returns the answer as an integer.
        public int Add(int number)
        {
            return number + 2;
        }

        // Takes a decimal and subtracts 2 from it then return the answer as an integer.
        public decimal Add(decimal number)
        {
            
            return Convert.ToInt32(number) - 2;
        }

        // Takes a string converts it into an integer and multiplies it by 2 then returns the answer as an integer.
        public int Add(string someString)
        {
            int value = Convert.ToInt32(someString);
            return value * 2;
        }
    }
}
