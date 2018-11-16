using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //Console.ReadLine();

            Console.WriteLine("Person 1");
            //Console.ReadLine();

            int person1Hr;
            Console.WriteLine("What is your Hourly Rate?");
            person1Hr = Console.Read();
            Console.ReadLine();

            int person1Hw;
            Console.WriteLine("How many hours do you work per week?");
            person1Hw = Console.Read();
            Console.ReadLine();

            //int person1Salary;
            //person1Salary = ((person1Hr * person1Hw) * 52);
            //Console.WriteLine("Your annual salary is " + person1Salary);
            Console.WriteLine(person1Hr);
            Console.WriteLine(person1Hw);
            Console.ReadLine();

            
        }
    }
}
