using System;
using System.Collections.Generic;

namespace GenericTypesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> strEmployee = new Employee<string>(); // Instantiates an Employee object with type "string" as its generic parameter.
            strEmployee.things = new List<string> { "One", "Two", "Three", "Four", "Five" }; // Assigns a list of strings as the property value of things.

            Employee<int> intEmployee = new Employee<int>(); // Instantiates an Employee object with type "int" as its generic parameter.
            intEmployee.things = new List<int> { 1, 2, 3, 4, 5 }; // Assigns a list of integers as the property value of things.

            foreach (string thing in strEmployee.things) // A loop that prints all of the things to the console.
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in intEmployee.things) // A loop that prints all of the things to the console.
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
