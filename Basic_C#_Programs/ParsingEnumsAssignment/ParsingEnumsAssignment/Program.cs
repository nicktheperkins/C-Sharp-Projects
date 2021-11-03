using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   // Asks the user for the day of the week and passes the input to the day variable.
            Console.WriteLine("Please enter the current day of the week.");
            string day = Console.ReadLine();

            try
            {   // This will test to see if the users input string can translate to an enum variable.
                // This will throw an exception if the string can't be parsed as a DaysOfTheWeek.
                DaysOfTheWeek foo = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day, true);
            }
            catch (Exception ex)
            {   // This prints a message if an exception is caught.
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }

        // This is an enum of the days of the week.
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
