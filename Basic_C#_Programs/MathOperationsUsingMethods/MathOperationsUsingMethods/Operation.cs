using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsUsingMethods
{
    public class Operation
    {
        // Adds to the users input and returns a value.
        public int Add(int number)
        {
            return number + 2;
        }

        // Divides the users input and returns a value.
        public int Divide(int number)
        {
            return number / 2;
        }

        // Multiplies the users input and return a value.
        public int Multiply(int number)
        {
            return number * 2;
        }
    }
}
