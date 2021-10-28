using System;

namespace VoidMethod
{
    class Operation
    {
        // This method takes two parameters.
        // On the first param it performs a math operation and then displays it on the console.
        // On the second param it just display it to the console.
        public void Add(int intOne, int intTwo)
        {
            Console.WriteLine(intOne + 2);
            Console.WriteLine(intTwo);
            Console.ReadLine();
        }
    }
}
