using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneRefined
{   // Everything is public in a interface.
    // Interfaces are very similar to abstract classes. Any class that inherits this interface has to implement its methods.
    // An interface is similar to and abstract class in that there are no implementation details.
    // The naming conventions for interfaces demands that the interface name starts with an upper case I.
    interface IWalkAway
    {
        void WalkAway(Player player);
    }
}
