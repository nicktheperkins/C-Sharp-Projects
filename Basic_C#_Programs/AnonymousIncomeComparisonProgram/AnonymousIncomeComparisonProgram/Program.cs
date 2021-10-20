using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string p1Rate = Console.ReadLine();
            int hourlyRateP1 = Convert.ToInt32(p1Rate);

            Console.WriteLine("Hours worked per week?");
            string p1Hours = Console.ReadLine();
            int hoursWorkedP1 = Convert.ToInt32(p1Hours);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string p2Rate = Console.ReadLine();
            int hourlyRateP2 = Convert.ToInt32(p2Rate);

            Console.WriteLine("Hours worked per week?");
            string p2Hours = Console.ReadLine();
            int hoursWorkedP2 = Convert.ToInt32(p2Hours);

            Console.WriteLine("Annual salary of Person 1:");
            int p1AnnualSalary = hourlyRateP1 * hoursWorkedP1 * 52;
            Console.WriteLine(p1AnnualSalary);

            Console.WriteLine("Annual salary of Person 2:");
            int p2AnnualSalary = hourlyRateP2 * hoursWorkedP2 * 52;
            Console.WriteLine(p2AnnualSalary);

            Console.WriteLine("Does Person 1 make more than Person 2?");
            bool compareSalary = p1AnnualSalary > p2AnnualSalary;
            Console.WriteLine(compareSalary);

            Console.Read();


        }
    }
}
