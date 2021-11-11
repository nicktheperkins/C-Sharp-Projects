using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var newEmployee = new Employee("Nick"); // This uses constructor chaining to instantiate a new employee.

            const string welcomeMessage = "Please welcome our newest employee: "; // This is a constant welcome message used to announce new employees.

            Console.WriteLine("{0}{1}", welcomeMessage, newEmployee.Name); // This writes the welcome message and the new employees name to the console.

            Console.Read();
        }
    }
}
