using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // This namespace contains the file class.

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\Nick\Downloads\log.txt", text); // Writes the text into a txt file and saves it in the downloads folder.
            //string readText = File.ReadAllText("C:\\Users\\Nick\\Downloads\\log.txt"); // Reads the text from the txt file saved in the downloads folder.

            
            DateTime yearOfBirth = new DateTime(1995, 6, 7, 7, 0, 0); // DateTime is a struct value type and is not nullable.
            DateTime yearOfGraduation = new DateTime(2013, 6, 1, 9, 0, 0);
            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth; // This will give the difference between the dates in days.

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
    }
}
