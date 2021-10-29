using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneRefined
{   // Class TwentyOneGame inherits from class Game.
    public class TwentyOneGame : Game
    {   // This method is specific to the class TwentyOneGame.
        // In order to implement the abstract method add the override keyword to satisfy the contract to define the abstract method.
        public override void Play()
        {
            // This throws an error.
            throw new NotImplementedException();
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
    }
}
