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
            

            Console.WriteLine("Person 1");
            

            float person1Hr;
            Console.WriteLine("What is your Hourly Rate?");
            person1Hr = Convert.ToSingle(Console.ReadLine());
            

            float person1Hw;
            Console.WriteLine("How many hours do you work per week?");
            person1Hw = Convert.ToSingle(Console.ReadLine());
            

            float person1Salary;
            person1Salary = ((person1Hr * person1Hw) * 52);
            Console.WriteLine("Your annual salary is " + person1Salary);
            
            Console.ReadLine();


            Console.WriteLine("Person 2");
            

            float person2Hr;
            Console.WriteLine("What is your Hourly Rate?");
            person2Hr = Convert.ToSingle(Console.ReadLine());
            

            float person2Hw;
            Console.WriteLine("How many hours do you work per week?");
            person2Hw = Convert.ToSingle(Console.ReadLine());
            

            float person2Salary;
            person2Salary = ((person2Hr * person2Hw) * 52);
            Console.WriteLine("Your annual salary is " + person2Salary);

            Console.ReadLine();

            Console.WriteLine("Does person 1 make more money than person 2?");
            if (person1Salary > person2Salary)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
        }
    }
}
