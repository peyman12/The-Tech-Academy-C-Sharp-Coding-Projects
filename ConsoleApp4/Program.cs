using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            string appAge;
            Console.WriteLine("What is your age?");
            appAge = Console.ReadLine();
            

            string appDUI;
            Console.WriteLine("Have you ever had a DUI? Answer: 'true' or 'false'.");
            appDUI = Console.ReadLine();
           

            string appTickets;
            Console.WriteLine("How many speeding tickets do you have?");
            appTickets = Console.ReadLine();
            

            if ((appDUI == "false") && (Convert.ToInt32(appAge) > 15) && (Convert.ToInt32(appTickets) < 4))
            {
                Console.WriteLine("Qualified?\n true");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Qualified \n false");
                Console.ReadLine();
            }
            

        }
    }
}
