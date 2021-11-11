using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // This namespace contains the file class.
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\Nick\Downloads\log.txt", text); // Writes the text into a txt file and saves it in the downloads folder.
            //string readText = File.ReadAllText("C:\\Users\\Nick\\Downloads\\log.txt"); // Reads the text from the txt file saved in the downloads folder.


            //DateTime yearOfBirth = new DateTime(1995, 6, 7, 7, 0, 0); // DateTime is a struct value type and is not nullable.
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 9, 0, 0);
            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth; // This will give the difference between the dates in days.

            //// The general rule for var is if the data type is in question you use var. But it is better to declare known data types for code readability. var implicitly defines a variable
            //var newDictionary = new Dictionary<string, string>(); // var can save typing by not adding Dictionary<string, string> before newDictionary.
            //var newPlayer = new Player("Nick"); // This assigns the name and gives a default balance of 100. This is called constructor chaining.
            //const string casinoName = "Grand Hotel and Casino"; // This is a constant. Once the program is compiled the constant can not change. This gives me more control over the program.
            //Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName); // This is an example of the constant being used.

            //Guid indentifier = Guid.NewGuid(); // Global Unique Identifier: guids are maining used to give an id to a user of the program. It it very dificult to create duplicate guids.

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Nick\Documents\GitHub\C-Sharp-Projects\Basic_C#_Programs\logs\log.txt", true)) // This logs the players Id to the txt file before they begin to play.
                {
                    file.WriteLine(player.Id);
                }
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
