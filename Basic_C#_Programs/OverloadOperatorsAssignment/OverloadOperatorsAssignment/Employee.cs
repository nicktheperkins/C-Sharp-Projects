using System;

namespace OverloadOperatorsAssignment
{
    public class Employee
    {   // ID property for my Employee class.
        public int ID { get; set; }

        // This is an overloaded equality operator. It compares the IDs of the two employees passed into it.
        public static bool operator ==(Employee e1, Employee e2)
        {
            return e1.ID == e2.ID;
        }

        // This is an overloaded inequality operator.
        // For the compiler to run the overloaded equality operator without errors the overloaded inequality operator needa to be defined.
        public static bool operator !=(Employee e1, Employee e2)
        {
            return e1.ID == e2.ID;
        }
    }
}
