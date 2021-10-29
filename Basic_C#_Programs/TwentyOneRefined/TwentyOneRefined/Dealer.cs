using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneRefined
{   // The reason we don't inherit from the deck class and add it to properties instead is because by doing that the dealer HAS A deck instead of the dealer IS A deck.
    // Inheritance causes the the dealer to become a deck.
    // Composition over Inheritance - Martin Fouler
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        // This method takes a list of cards as an input parameter.
        public void Deal(List<Card> Hand)
        {
            // This adds a card to the hand. First is a method available to a list that takes the very first item in the list.
            Hand.Add(Deck.Cards.First());
            // This prints the card that was dealt.
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            // This then removes the card that was dealt from the deck.
            Deck.Cards.RemoveAt(0);
        }
    }
}
