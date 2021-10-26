using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // A list of integers
            // Asks the user for a number to divide each number in the list by.
            List<int> numbers = new List<int>() { 100, 75, 50, 25, 55, 40, 30 };
            Console.WriteLine("Input a number.");
            int denominator = Convert.ToInt32(Console.ReadLine());

            // A loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
            foreach (int number in numbers)
            {
                int quotient = number / denominator;
                Console.WriteLine($"{number} divided by {denominator} equals {quotient}");
            }
            Console.ReadLine();
        }
        // Catches any errors and displays them on the screen.
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        // Final message as the try/catch block ends and the program continues its execution.
        finally
        {
            Console.WriteLine("The program has now emerged from the try/catch block and continues with program execution.");
            Console.ReadLine();
        }
        
    }
}
