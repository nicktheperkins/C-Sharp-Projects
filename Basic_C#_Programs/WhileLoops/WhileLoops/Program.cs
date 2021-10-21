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
            int i = 1;
            while (i < 6)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Guess a number between 1 and 5.");
            int number = Convert.ToInt32(Console.ReadLine());

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
