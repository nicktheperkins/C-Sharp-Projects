using System;
using System.Collections.Generic;

namespace TwentyOneRefined
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++) // This is a nested for loop.
                {
                    Card card = new Card(); // This instantiates a new card.
                    card.Face = (Face)i; // This iterates through all thirteen faces.
                    card.Suit = (Suit)j; // This iterates through all four suits.
                    Cards.Add(card); // This adds each card to the cards list.
                }
            }

            //// This section of code was deleted because we are using enums now.
            //List<string> Suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            //List<string> Faces = new List<string>()
            //{
            //    "Two", "Three", "Four", "Five", "Six", "Seven",
            //    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            //};

            //foreach (string face in Faces)
            //{
            //    foreach (string suit in Suits)
            //    {
            //        Card card = new Card();
            //        card.Suit = suit;
            //        card.Face = face;
            //        Cards.Add(card);
            //    }
            //}
        }
        public List<Card> Cards { get; set; }


        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }

                Cards = TempList;
            }
        }
    }
}
