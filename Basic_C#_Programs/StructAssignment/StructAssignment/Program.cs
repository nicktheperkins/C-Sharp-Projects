using System;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This creates a Number object and assigns it an Amount.
            Number num1 = new Number();
            num1.Amount = 10.5M;

            // This writes the Amount I assigned to the console.
            Console.WriteLine(num1.Amount);
            Console.ReadLine();
        }
    }
}
