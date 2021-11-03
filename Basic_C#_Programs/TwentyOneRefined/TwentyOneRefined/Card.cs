using System;

namespace TwentyOneRefined
{
    public class Card
    {   //// This was commented out since we are using enums now.
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }

    // This is a defined enum for suit.
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    // This is a defined enum for Face.
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
