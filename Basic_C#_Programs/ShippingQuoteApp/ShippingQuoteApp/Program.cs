using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Asks the user for the package weight and evaluates whether package is to heavy to ship or not. If the package is to heavy then the program ends.
            Console.WriteLine("Please enter the package weight:");
            string sWeight = Console.ReadLine();
            int weight = Convert.ToInt32(sWeight);
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }

            // Asks the user to input the package width and evaluates whether the package is to big or not. If the package is to big then the program ends.
            Console.WriteLine("Please enter the package width:");
            string sWidth = Console.ReadLine();
            int width = Convert.ToInt32(sWidth);
            if (width > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }

            // Asks the user to input the package height and evaluates whether the package is to big or not. If the package is to big then the program ends.
            Console.WriteLine("Please enter the package height:");
            string sHeight = Console.ReadLine();
            int height = Convert.ToInt32(sHeight);
            if (height > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }

            // Asks the user to input the package length and evaluates whether the package is to big or not. If the package is to big the program ends.
            Console.WriteLine("Pleae enter the package length:");
            string sLength = Console.ReadLine();
            int length = Convert.ToInt32(sLength);
            if (length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }


            double estimate = (weight * width * height * length) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: {0:C2}", estimate);
            Console.WriteLine("Thank you!");

            Console.Read();
        }
    }
}
