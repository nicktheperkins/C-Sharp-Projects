using System.Collections.Generic;
using System.Linq;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   // Creates a list of 10 employees with an Id, first name, and last name.
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, firstName = "Joe", lastName = "Smith"},
                new Employee() { Id = 2, firstName = "Nick", lastName = "Perkins"},
                new Employee() { Id = 3, firstName = "Katie", lastName = "Perkins"},
                new Employee() { Id = 4, firstName = "Tom", lastName = "Knorr"},
                new Employee() { Id = 5, firstName = "Andrew", lastName = "Knorr"},
                new Employee() { Id = 6, firstName = "Jonny", lastName = "Corliss"},
                new Employee() { Id = 7, firstName = "Bri", lastName = "Corliss"},
                new Employee() { Id = 8, firstName = "Kiara", lastName = "Taylor"},
                new Employee() { Id = 9, firstName = "Michael", lastName = "Taylor"},
                new Employee() { Id = 10, firstName = "Joe", lastName = "Knorr"},
            };

            // A foreach loop that create a new list of employees with the first name Joe.
            List<Employee> firstNameJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    firstNameJoe.Add(employee);
                }
                else
                {

                }
            }

            // A lambda expression that create a new list of employees with the first name Joe.
            List<Employee> firstNameJoe2 = employees.Where(x => x.firstName == "Joe").ToList();

            // A lambda expression that creates a new list of employees with Id's greater than 5.
            List<Employee> idGreaterThanFive = employees.Where(x => x.Id > 5).ToList();
        }
    }
}
