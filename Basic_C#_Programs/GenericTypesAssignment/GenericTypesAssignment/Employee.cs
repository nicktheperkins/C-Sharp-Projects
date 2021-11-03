using System.Collections.Generic;

namespace GenericTypesAssignment
{   
    public class Employee<T> // This is a class that takes a generic type parameter.
    {
        public List<T> things { get; set; } // A property that is a generic list with the same generic data type as the class.
    }
}
