using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number: ");

            string stringInput = Console.ReadLine();
            int input = Convert.ToInt32(stringInput);

            // Takes an input from the user, multiplies it by 50, then prints the result to the console.
            int product = input * 50;
            Console.WriteLine("Input * 50 = " + product);

            // Takes an input from the user, adds 25 to it, then prints the result to the console.
            int total = input + 25;
            Console.WriteLine("Input + 25 = " + total);

            // Takes an input from the user, divides it by 12.5, then prints the result to the console.
            double quotient = input / 12.5;
            Console.WriteLine("Input / 12.5 = " + quotient);

            // Takes an input from the user, checks if it is greater than 50, then prints the true/flase result to the console.
            bool greaterThan = input > 50;
            Console.WriteLine("Input > 50 = " + greaterThan);

            // Takes an input from the user, divides it by 7, then prints the remainder to he console.
            int remainder = input % 7;
            Console.WriteLine("Remainder of Input / 7 = " + remainder);

            Console.Read();
        }
    }
}
