using System;

namespace ConstructorAssignment
{
    class Employee
    {
        public Employee(string name) : this(name, 10) // This is a constructor call chain that assigns default pay value when only a name is entered into it.
        {

        }

        public Employee(string name, int pay) // This is that main employee constructor used to record the new employees name and pay rate.
        {
            Pay = pay;
            Name = name;
        }

        public int Pay { get; set; } // This is an integer property for the employee's pay rate.
        public string Name { get; set; } // This is a string property for the employee's name.
    }
}
