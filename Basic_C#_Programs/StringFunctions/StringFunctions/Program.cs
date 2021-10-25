using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nick";
            string quote = "The man said, \\Hello\", Nick. \nHello on a new line. \n\tHello on a tab.";
            // Everything after the @ and in between the "" is part of the string. There are no escape characters.
            string fileName = @"C:\Users\Nick";

            // The .Contains method is case sensitive.
            bool trueOrFalse = name.Contains("n");
            // The most most recent trueOrFalse variable get printed. The previous variable is not printed at all.
            trueOrFalse = name.EndsWith("k");

            int length = name.Length;

            name = name.ToUpper();
            name = name.ToLower();


            Console.WriteLine(name);
            Console.WriteLine(length);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(quote);
            Console.ReadLine();

            // Strings are immutable

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Nick");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
