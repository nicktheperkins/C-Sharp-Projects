using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number."); // Asks the user to input a number.
            string input = Console.ReadLine(); // Reads the users input into the string variable input.

            string location = @"C:\Users\Nick\Documents\GitHub\C-Sharp-Projects\Basic_C#_Programs\logs\inputLog.txt"; // String variable for the file location.

            File.WriteAllText(location, input); // Writes the users input to the txt file.

            Console.WriteLine("Your input was saved to the following location: \n{0}", location); // Lets the user know that their input has been saved to the file location.
            Console.Read();
        }
    }
}
