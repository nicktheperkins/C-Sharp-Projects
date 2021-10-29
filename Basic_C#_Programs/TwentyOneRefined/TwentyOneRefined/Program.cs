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

            // This is implimentation of the virtual method we created.
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Nick", "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }
    }
}
