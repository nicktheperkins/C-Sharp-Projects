using System;

namespace MethodswithMultipleParameters
{
    class Operation
    {
        // This is a method that runs a math operation on two parameters, but the second parameter is optional.
        public int Add(int numOne, int numTwo = 1)
        {
            return (numOne + 2) * numTwo;
        }
    }
}
