using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneRefined
{   // Class TwentyOneGame inherits from class Game.
    // The .NET framework doesn't support multiple inheritance.
    // To work around that you can build interfaces and a class can inherit as many as it wants.
    public class TwentyOneGame : Game, IWalkAway
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

        // This is satisfying the interface by adding its method into the inheriting class.
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
