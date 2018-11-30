using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {  
            static void Main(string[] args)
            {
            //by changing the id values in brackets we can execute either the if statement of the else statement
            Employee id1 = new Employee(1);
            Employee id2 = new Employee(2);


            if (id1 == id2)
            {
                Console.WriteLine("The Employee Ids are the same.");
            }
            else
            {
                Console.WriteLine("The Employee Ids are different.");
            }
            Console.ReadLine();
            }
        static void Quit(IQuittable employee)
        {
            employee.Quit();
        }
    }
 }
    

