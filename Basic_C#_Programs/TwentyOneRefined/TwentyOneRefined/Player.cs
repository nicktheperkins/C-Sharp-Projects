using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneRefined
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        // This is an overloaded operator method that overloads the operator plus.
        // It takes two operands (game & player) and returns a Game.
        // Why would we want to overload an operator? It allows me to make my own implementation of the operator.
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        // This is an overloaded minus operator.
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
