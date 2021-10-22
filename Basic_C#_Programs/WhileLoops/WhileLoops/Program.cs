using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a while loop that iterates through five numbers 1-5.
            int i = 1;
            while (i < 6)
            {
                Console.WriteLine(i);
                i++;
            }

            // This is an entry message to start the guessing portion of this program
            Console.WriteLine("Guess a number between 1 and 5.");
            int number = Convert.ToInt32(Console.ReadLine());

            // This is a boolean comparison using a do while loop. The program will keep asking the user to guess a number until they guess the right number
            bool guess = number == 5;
            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed number 1. Try again.");
                        Console.WriteLine("Guess a number between 1 and 5.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed number 2. Try again.");
                        Console.WriteLine("Guess a number between 1 and 5.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed number 3. Try again.");
                        Console.WriteLine("Guess a number between 1 and 5.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed number 4. Try again.");
                        Console.WriteLine("Guess a number between 1 and 5.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed number 5. That is correct!");
                        guess = true;
                        break;
                    default:
                        Console.WriteLine("That is not a number between 1 and 5. Try again.");
                        Console.WriteLine("Guess a number between 1 and 5.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!guess);

            Console.Read();
        }
    }
}
