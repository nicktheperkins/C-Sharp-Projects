using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOpsUsingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates my Operations class.
            Operation operation = new Operation();

            // Calls my three methods passing integer, decimal, and string parameters.
            int method1 = operation.Add(1);
            decimal method2 = operation.Add(10.1M);
            int method3 = operation.Add("10");

            // Writes the answers of my methods to the console.
            Console.WriteLine(method1);
            Console.WriteLine(method2);
            Console.WriteLine(method3);
            Console.ReadLine();
        }
    }
}
