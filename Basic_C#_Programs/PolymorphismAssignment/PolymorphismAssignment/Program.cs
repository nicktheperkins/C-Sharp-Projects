using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This uses polymorphism to create an object of the type IQuitable and calls the Quit() method.
            IQuitable quit = new Employee();
            quit.Quit();

            Console.ReadLine();
        }
    }
}
