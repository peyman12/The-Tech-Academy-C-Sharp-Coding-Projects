using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();

            employee.Things = new List<string> { "Doug", "Jim", "Rory", "Walt" };

            Employee<int> employee2 = new Employee<int>();

            employee2.Things = new List<int> { 2, 4, 5, 9 };

            foreach (string item in employee.Things)
            {
                Console.WriteLine(item);
            }

            foreach (int item in employee2.Things)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
