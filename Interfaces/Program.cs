using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable name = new Employee();
            Employee employees = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            //hitting enter quits the program
            employees.SayName();
            Console.ReadLine();
            name.Quit();
        }
    }
}
