using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiated an object called Deck
            Deck deck = new Deck();
            // Shuffles the deck and returns the value of the newly shuffled deck back to it.
            deck = Shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            //// Deleted this section to build the deck with cards already pre filled out instead of filling them out one card at a time.
            //deck.Cards = new List<Card>();
            //// Instantiated an object called Card
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        // This a function in C# also know as a method.
        // A method has to be part of a/an Class.
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                // Creates a random index between 0 & 52. Adds that card at the random index to the temporary list. Removes the card that was added to the temporary list from the deck.
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
                // This will loop through the deck until its empty.
            }
            // Now we assign the temp list to the deck that is now empty.
            deck.Cards = TempList;
            // Finally we return the shuffled deck.
            return deck;
        }
    }
}
