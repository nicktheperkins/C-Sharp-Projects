using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneRefined
{
    class Program
    {
        static void Main(string[] args)
        {
            //// An easy way to create an object with values. It is called object initialization.
            //// Card card = new Card() {Face: "King", Suit: "Spades"};

            //// Instantiating the game class and adding some properties.
            ////Game game = new Game();
            ////game.Dealer = "Nick";
            ////game.Name = "Black Jack";

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Nick", "Jesse", "Bill", "Joe" };
            //// This is a call to a super class method. This is when you call a method you are inheriting from.
            //game.ListPlayers();
            //// This is a call to the Play method of the TwentyOneGame object.
            //game.Play();
            //Console.ReadLine();

            //// This is classic polymorphism. This also adds the TwentyOneGame to a list of games.
            //List<Game> games = new List<Game>();
            //Game game = new TwentyOneGame();
            //games.Add(game);

            //// This is implimentation of the virtual method we created.
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Nick", "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();

            // This is an example of how to add and remove players to and from a game.
            Game game = new TwentyOneGame(); // This instantiates a new TwentyOneGame object.
            game.Players = new List<Player>(); // This instatiates a new object list of players. This needs to be done before we add anything. List require instantiation before they can be added to.
            Player player = new Player(); // This instantiates a player object.
            player.Name = "Nick"; // This adds a name to the player through the name property.
            game += player; //game = game + player; // This adds the player we instantiated and named earlier to a TwentOneGame. This also uses the plus overload operator.
            game -= player; //game = game - player; // This removes the player from the TwentyOneGame. This uses the minus overload operator.


            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
