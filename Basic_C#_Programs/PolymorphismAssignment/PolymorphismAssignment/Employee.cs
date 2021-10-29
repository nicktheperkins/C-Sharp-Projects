using System;

namespace PolymorphismAssignment
{   // The Employee class inherits the IQuitable interface.
    public class Employee : IQuitable
    {
        public int ID { get; set; }

        // This satisfies the interface by adding its method into the Employee inheriting class.
        public void Quit()
        {
            Console.WriteLine("I quite!");
        }
    }
}
