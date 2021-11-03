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

            //// This is implimentation of the virtual method we created.
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Nick", "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();

            //// This is an example of how to add and remove players to and from a game.
            //Game game = new TwentyOneGame(); // This instantiates a new TwentyOneGame object.
            //game.Players = new List<Player>(); // This instatiates a new object list of players. This needs to be done before we add anything. List require instantiation before they can be added to.
            //Player player = new Player(); // This instantiates a player object.
            //player.Name = "Nick"; // This adds a name to the player through the name property.
            //game += player; //game = game + player; // This adds the player we instantiated and named earlier to a TwentOneGame. This also uses the plus overload operator.
            //game -= player; //game = game - player; // This removes the player from the TwentyOneGame. This uses the minus overload operator.

            // These are some notes on the generics video. There are no code examples as none of them were kept in this program.
            // Generics are a feature of the language that allows you to write generic classes or generic functions.
            // The most common usage with generics is inside the list class List<T>.
            // The idea I can pass in a data type into a list on creation (Ex. List<string>, List<int>) and it affects the rest of the class is generics.
            // Generics is one more way of abstracting my code to emcompass more situations. This results in more code reuse and better adaptability.

            //// Enums limit the possible values you can receive from a user.
            //// Another advantage to enums is intellisense. It lists all the variables set in the enum making coding faster.
            //DaysOfTheWeek day = DaysOfTheWeek.Monday;
            //Console.WriteLine(day);

            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = (int)Suit.Diamonds; // Here we cast Suit.Diamonds to an integer. The underlying data type of an enum variable is integer.
            //Console.WriteLine(underlyingValue); // This writes the value that Diamonds is assigned in the enum. You can change this number if you want.


            //// Every data type in C# is either a reference type of a value type. These two type have different behaviors.
            //// Any data type that stores data by reference is a reference type.
            //// Classes are reference types. Classes operate by reference.
            //// You can reference a class from where it is stored in memory many times in your program but it is still the same location you are referencing the class from.
            //Card card1 = new Card();
            //Card card2 = card1; // card2 is not an independent object is just has the memory address to card1. It is a reference to card1.
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;
            //Console.WriteLine(card1.Face); // Result: King // When we changed the card class to a struct the result was Eight. This means that when a card is created it is its own individual object.
            //List<string> // The definition for the  class List can be viewed by right clicking on it and then clicking Go To Definition. There you see all its properties and methods.
            //// Some built in value types are integers, booleans, enums, and date time data types.
            //// An integer is not a class it is a struct. A struct is the same as a class, except that it is a value type. A struct can't be inherited.
            //// Value types can't have a value of null. They are non-nullable.
            //int number = 5;

            // Lambda functions have their roots in an offshoot of math called Lambda Calculus invented in the 1930's
            // Lambda functions in C# expose lists to a variety of handy method that make life easier.
            // Lambda expressions are hard to debug. A lamda function exposes lists to a variety of methods.
            Deck deck = new Deck();
            int counter = 0;
            foreach(Card card in deck.Cards)
            {
                if (card.Face == Face.Ace)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            // This Lambda expression does that same thing as the function above.
            int count = deck.Cards.Count(x => x.Face == Face.Ace);
            Console.WriteLine(count);
            // This creates a new list of cards that have a face of King and writes them to the console.
            List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            foreach (Card card in newList)
            {
                Console.WriteLine(card.Face);
            }
            // This creates a new list of numbers adds five to each number and sums them to write to the console.
            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
            int sum = numberList.Sum(x => x +5);
            int sum2 = numberList.Max(); // This find the maximum value in the list.
            int sum3 = numberList.Min(); // This find the minimum value in the list.
            int sum4 = numberList.Where(x => x > 20).Sum(); // This makes a list of items that are greater than 20 and sums that list.
            Console.WriteLine(sum4);

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //public enum DaysOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
    }
}
