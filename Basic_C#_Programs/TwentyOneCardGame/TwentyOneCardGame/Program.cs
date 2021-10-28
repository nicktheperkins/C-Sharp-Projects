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
                //deck = Shuffle(deck);
                //deck = Shuffle(deck, 3);

            // Below is a named parameter example. This is mostly done for readablity reasons.
                //deck = Shuffle(deck: deck, times: 3);

            // Need to add the timesShuffled variable to call it in the Shuffle method.
                // int timesShuffled = 0;

            // This is shuffling the deck 3 times and then sending out the count of shuffles to the variable above.
                // deck = Shuffle(deck, out timesShuffled, 3);

            deck.Shuffle();

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
            // This calles the variable timesShuffled. I can format the string further by adding another bracket {1} with another variable to display (Console.WriteLine("Times shuffled: {0} {1}", timesShuffled, anotherVariable);)
                // Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }


        // Method overloading is the term for being able to create multiple methods with the same name as long as they are slightly different. Below is and example of Method Overloading.
            //public static Deck Shuffle(Deck deck, int times)
            //{
            //    for(int i = 0; i < times; i ++)
            //    {
            //        deck = Shuffle(deck);
            //    }
            //    return deck;
            //}
    }
}
