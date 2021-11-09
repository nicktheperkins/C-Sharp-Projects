using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Nick\Documents\GitHub\C-Sharp-Projects\Basic_C#_Programs\logs\log.txt", true)) // This is a using statement that instantiates a StreamWriter object to write any newly dealt card to a txt file.
            {
                file.WriteLine(DateTime.Now); // This creates a timestamp.
                file.WriteLine(card);
            } // Once this closing brace is hit the memory manager will clean up the using statement and dispose of the resources.
            Deck.Cards.RemoveAt(0);
        }
    }
}
