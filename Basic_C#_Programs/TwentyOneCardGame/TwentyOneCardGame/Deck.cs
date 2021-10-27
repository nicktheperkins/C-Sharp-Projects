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
    }
}
