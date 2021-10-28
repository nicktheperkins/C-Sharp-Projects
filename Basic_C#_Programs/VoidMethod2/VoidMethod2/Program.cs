using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates my operation class.
            Operation o = new Operation();

            // Asks the user to enter a number and converts the string to an integer.
            Console.WriteLine("Please enter a number.");
            int numOne = Convert.ToInt32(Console.ReadLine());

            // Calls my overloaded void method to display the users integer divided by 2 on the console.
            o.Add(numOne);

            // Need to add the local variable definition to call it in the method.
            int x, y;
            // Calls my overloaded void method with two output parameters and writes the values to the console.
            o.Add(out x, out y);
            Console.WriteLine("After method call, value of x : {0}", x);
            Console.WriteLine("After method call, value of y: {0}", y);

            // Calls my static method in my static class called Author.
            Author.details();

            Console.ReadLine();
        }
    }
}
