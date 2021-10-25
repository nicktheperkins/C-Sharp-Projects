using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string yes = "Yes";
            string or = "or";
            string no = "No";

            // Concatenates the three string above.
            string yesOrNo = yes + or + no;
            Console.WriteLine(yesOrNo);
            Console.ReadLine();

            // Converts a string to uppercase.
            string OR = or.ToUpper();
            Console.WriteLine(OR);
            Console.ReadLine();

            // Creates a StringBuilder and builds a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();
            sb.Append("In C#, the string type is immutable.");
            sb.Append(" It means a string cannot be changed once created.");
            sb.Append(" For example, a new string, \"Hello World!\" will occupy a memory space on the heap.");
            sb.Append(" Now, by changing the initial string \"Hello World!\" to \"Hello World! from Tutorials Teacher\" will create a new string object on the memory heap instead of modifying an original string at the same memory address.");
            sb.Append(" This behavior would hinder the performance if the original string changed multiple times by replacing, appending, removing, or inserting new strings in the original string.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
