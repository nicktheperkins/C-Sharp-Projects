using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks if the user is older than 15 and evalutes whether that is true or false.
            Console.WriteLine("What is your age?");
            string sAge = Console.ReadLine();
            int age = Convert.ToInt32(sAge);
            bool oldEnough = age > 15;
            //Console.WriteLine(oldEnough);

            // Asks the user if they have a DUI and evaluate whether that is true of false.
            Console.WriteLine("Have your ever had a DUI?");
            string sDUI = Console.ReadLine();
            bool DUI = Convert.ToBoolean(sDUI);
            bool hasDUI = (DUI == false);
            //Console.WriteLine(hasDUI);

            // Asks the user if they have more than 3 tickets and evaluates whether that is true of false.
            Console.WriteLine("How many speeding tickets do you have?");
            string sTicket = Console.ReadLine();
            int Ticket = Convert.ToInt32(sTicket);
            bool Tickets = Ticket <= 3;
            //Console.WriteLine(Tickets);

            // If all previous conditions are met then the user is qualified.
            Console.WriteLine("Qualified?");
            bool qualified = (oldEnough && hasDUI && Tickets);
            Console.WriteLine(qualified);

            Console.Read();
        }
    }
}
