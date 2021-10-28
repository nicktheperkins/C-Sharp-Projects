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
            int timesShuffled = 0;
            // This is shuffling the deck 3 times and then sending out the count of shuffles to the variable above.
            deck = Shuffle(deck, out timesShuffled, 3);

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
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }

        // This a function in C# also know as a method.
        // A method has to be part of a/an Class.
        // You can give a method an optional peramater. To do this we create the option with a default value. (int times = 1)
        // We added an out variable to show how many times the deck was shuffled. All it does is it returns a value when called. (out int timesShuffled)
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            // This is variable that we add a count to for the out variable.
            timesShuffled = 0;
            for(int i = 0; i < times; i++)
            {
                timesShuffled++;
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
            }
            // Finally we return the shuffled deck.
            return deck;
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
