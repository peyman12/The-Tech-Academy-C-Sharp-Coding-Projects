using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {

            {


                Console.WriteLine("Enter the day of the week");
                string userInput = Console.ReadLine();

                try
                {

                    Enum.Parse(typeof(DayOfWeek), userInput);
                    Console.WriteLine("Correct! today is " + userInput);
                    Console.ReadLine();
                }


                catch (FormatException)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
                Console.ReadLine();
            }

         

    }
    }
} 

