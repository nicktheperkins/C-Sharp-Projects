using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates and initializes an Employee object. It also sets the first and last name properties.
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            // This calls the supperclass virtual method SayName from the inherited abstract Person class.
            employee.SayName();

            Console.ReadLine();
        }
    }
}
