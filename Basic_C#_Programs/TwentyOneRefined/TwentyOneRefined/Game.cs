using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneRefined
{   // An abstract class can never be instantiated/be an object. Its only meant to be inherited from.
    public abstract class Game
    {   // prop + tab + tab - this a shortcut to initialize properties inside of a class. Think of this like a template command for a property.
        // public int MyProperty { get; set; }
        // Below are properties of the game class. List of players, game name, and game dealer.
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        // An abstract method can only exist instide of an abstract class. An abstract method contains no implementation.
        // All an abstract method does is state that any class inheriting this class must implement this method.
        public abstract void Play();

        // This is a void method that list the players on the console.
        // A virtual method inside of an abstract class means that this method gets inherited but the inheriting class has the ability to override it.
        // Virtual methods do have implimentation.
        public virtual void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
