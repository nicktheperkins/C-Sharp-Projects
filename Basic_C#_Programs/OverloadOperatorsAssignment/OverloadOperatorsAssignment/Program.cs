using System;

namespace OverloadOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates and sets the ID property for the two employees I am going to compare.
            Employee e1 = new Employee { ID = 112233 };
            Employee e2 = new Employee { ID = 445566 };

            // This uses my overloaded equality operator to compare the IDs of the two employees.
            bool equality = e1 == e2;

            // This writes and reads my comparison to the console.
            Console.WriteLine(equality);
            Console.ReadLine();
        }
    }
}
