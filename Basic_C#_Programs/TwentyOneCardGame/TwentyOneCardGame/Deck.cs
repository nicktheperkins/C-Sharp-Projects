using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneCardGame
{
    public class Deck
    {
        // Constructors go at the top of the class before the properties.
        public Deck()
        {
            // Inside of our class we have a constructor which is a method that is called as soon as an object is created.
            // First thing is does is instantiates its property cards as an empty list of cards.
            Cards = new List<Card>();
            // Second it creates two more lists and instantiates them with values.
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            // Nested foreach loop
            // For each of the items in the faces list we loop through each suit (which is 4 times).
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    // During each loop we create a card and assign its suit and face and add the new card into our cards list.
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

            //// Deleted this sections because we are going to use a foreach loop to do that same thing, but more of it.
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
        }
        public List<Card> Cards { get; set; }


        // This a function in C# also know as a method.
        // A method has to be part of a/an Class.
        // You can give a method an optional paramater. To do this we create the option with a default value. (int times = 1)
        // We added an out variable to show how many times the deck was shuffled. All it does is it returns a value when called. (out int timesShuffled)
        // Static means you can call the method and not have it apply to the deck you just created.
        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        public void Shuffle(int times = 1)
        {
            // This is variable that we add a count to for the out variable.
                //timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                    //timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                // This will loop through the deck until its empty.
                    // while (deck.Cards.Count > 0) // deck. was used when we had this method in the main program not in the class as it is now.
                while (Cards.Count > 0)
                {
                    // Creates a random index between 0 & 52.
                        // int randomIndex = random.Next(0, deck.Cards.Count); // deck. was used when we had this method in the main program not in the class as it is now.
                    int randomIndex = random.Next(0, Cards.Count);
                    //Adds that card at the random index to the temporary list.
                        //TempList.Add(deck.Cards[randomIndex]); // deck. was used when we had this method in the main program not in the class as it is now.
                    TempList.Add(Cards[randomIndex]);
                    // Removes the card that was added to the temporary list from the deck.
                        // deck.Cards.RemoveAt(randomIndex); // deck. was used when we had this method in the main program not in the class as it is now.
                    Cards.RemoveAt(randomIndex);
                }
                // Now we assign the temp list to the deck that is now empty.
                    // deck.Cards = TempList; // deck. was used when we had this method in the main program not in the class as it is now.
                // When you see the keyword this it means that it is referring to itself. Its own object
                    //this.Cards = TempList;
                Cards = TempList;
            }
            // Finally we return the shuffled deck.
                //return deck;
        }
    }
}
