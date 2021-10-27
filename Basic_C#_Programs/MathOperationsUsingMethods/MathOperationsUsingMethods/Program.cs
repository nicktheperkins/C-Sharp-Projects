using System;

namespace MathOperationsUsingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates my Operation class
            Operation operation = new Operation();

            // Asks the user what number they want to to do the math opertions on.
            Console.WriteLine("Enter a number that you want math oeprations performed on.");
            int number = Convert.ToInt32(Console.ReadLine());

            // Calls each method in turn and assigns it to a variable.
            int method1 = operation.Add(number);
            int method2 = operation.Divide(number);
            int method3 = operation.Multiply(number);
            
            // Writes the results of the math operations to the console.
            Console.WriteLine($"{number} plus 2  equals " + method1);
            Console.WriteLine($"{number} divided by 2 equals " + method2);
            Console.WriteLine($"{number} multiplied by 2 equals " + method3);
            Console.ReadLine();
        }
    }
}
