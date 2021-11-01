using System;

namespace ClassInheritanceAssignment
{
    public class Person
    {
        // These are two string properties of the class Person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // This a void method that displays the name properties on the console.
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
