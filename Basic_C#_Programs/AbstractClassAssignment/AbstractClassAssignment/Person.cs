using System;

namespace AbstractClassAssignment
{
    public abstract class Person
    {
        // These are two string properties of the class Person
        public string firstName { get; set; }
        public string lastName { get; set; }

        // This is a virtual method that displays the name properties on the console.
        public virtual void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
    }
}
