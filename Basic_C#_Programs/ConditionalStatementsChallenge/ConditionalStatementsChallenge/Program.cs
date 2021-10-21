using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nick";

            if (name == "Nick")
            {
                Console.WriteLine("Your name is Nick");
            }
            else if (name == "Mike")
            {
                Console.WriteLine("Your name is Mike");
            }
            else
            {
                Console.WriteLine("Your name is not Nick or Mike.");
            }

            Console.ReadLine();
        }
    }
}
