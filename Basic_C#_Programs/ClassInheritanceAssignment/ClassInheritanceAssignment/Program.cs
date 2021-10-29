using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates and initializes an Employee object. It also sets First and Last name properties.
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // This calls the superclass method SayName from the inherited Person class.
            employee.SayName();

            Console.ReadLine();
        }
    }
}
