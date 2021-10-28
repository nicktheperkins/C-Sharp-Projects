using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod2
{
    // This is my static class called Author
    static class Author
    {
        // This is a static method the doesn't return any values because its also a void method.
        // But it does write a message to the console when called.
        public static void details()
        {
            Console.WriteLine("The Author of this console app is: Nick Perkins");
        }
    }
}
