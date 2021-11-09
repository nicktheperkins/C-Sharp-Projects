using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now; // Sets the current date and time to a variable.
            Console.WriteLine("The current date and time is: {0}", currentTime); // Writes the current date and time to the console.

            Console.WriteLine("Please enter a number."); // Asks the user to enter a number.
            int hours = Convert.ToInt32(Console.ReadLine()); // Converts the users answer to and integer and sets it to a variable.

            DateTime xHoursLater = currentTime.AddHours(hours); // Adds the users number in hours to the current time.

            Console.WriteLine("The time will show {0}, {1} hours later.", xHoursLater, hours); // Tells the user what the time will be when the number of hours is added.
            Console.ReadLine();
        }
    }
}
