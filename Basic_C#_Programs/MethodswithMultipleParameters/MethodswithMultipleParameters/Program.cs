using System;

namespace MethodswithMultipleParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates my operations class.
            Operation operation = new Operation();

            // Asks the user to input a number and converts that number to an integer.
            Console.WriteLine("Enter a number to add 2 to that number.");
            int numOne = Convert.ToInt32(Console.ReadLine());

            // Asks the user to input another number if they want.
            Console.WriteLine("Enter a number to multiply the total from the last entry by. (This is optional, you can leave this blank.)");
            string numTwo = Console.ReadLine();

            // If the user provides a second number then I call my method with both parameters. If not I call the method with only one of the parameters.
            if (string.IsNullOrWhiteSpace(numTwo))
            {
                int method = operation.Add(numOne);
                Console.WriteLine("{0} plus 2 equals {1}", numOne, method);
                Console.ReadLine();
            }
            else
            {
                int stringTwoNum = Convert.ToInt32(numTwo);
                int method = operation.Add(numOne, stringTwoNum);
                Console.WriteLine("{0} plus 2 times {1} equals {2}", numOne, stringTwoNum, method);
                Console.ReadLine();
            }
        }
    }
}
