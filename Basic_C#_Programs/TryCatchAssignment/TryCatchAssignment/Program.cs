using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime todaysDate = DateTime.Today;
            string currentYear = todaysDate.ToString("yyyy");

            try
            {
                bool validAnswer = false;
                int age = 0;
                Console.WriteLine("Please enter your age.");
                validAnswer = int.TryParse(Console.ReadLine(), out age);
                if (!validAnswer)
                {
                    Console.WriteLine("Please enter digits only, no decimals.");
                    Console.ReadLine();
                }
                else if (age > 0)
                {
                    int yearBorn = (Convert.ToInt32(currentYear) - age);
                    Console.WriteLine("You were born in the year {0}", yearBorn);
                    Console.ReadLine();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You must enter a number that is greater than 0.");
                Console.ReadLine();
            }
        }
    }
}
