using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneRefined
{
    public class Game
    {   // prop + tab + tab - this a shortcut to initialize properties inside of a class. Think of this like a template command for a property.
        // public int MyProperty { get; set; }
        // Below are properties of the game class. List of players, game name, and game dealer.
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        // This is a void method that list the players on the console.
        public void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
