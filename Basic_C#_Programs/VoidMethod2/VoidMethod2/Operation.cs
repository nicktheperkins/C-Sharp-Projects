using System;

namespace VoidMethod2
{
    class Operation
    {
        // This is a void method that displays an integer to the console.
        public void Add(int numOne)
        {
            Console.WriteLine(numOne / 2);
            Console.ReadLine();
        }

        // This is a void method with two output parameters that overloads my previoud method.
        public void Add(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
}
