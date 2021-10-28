using System;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates my opertion class
            Operation operation = new Operation();

            // Calls the method and passes in two parameters.
            operation.Add(1, 2);

            // Calls the method and passes in two parameters by name.
            operation.Add(intOne: 2, intTwo: 1);
        }
    }
}
