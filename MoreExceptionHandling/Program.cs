using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your age.");
            try
            {
                bool validAnswer = false;
                int age = 1;
                while (!validAnswer)
                {
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Enter a whole number greater than zero.");
                }
                if (age <= 0)
                {
                    throw new Age();
                }

                DateTime currentYear = DateTime.Now;
                int CurrentYear = Convert.ToInt32(currentYear.Year);
                int YearOfBorn = CurrentYear - age;
                Console.WriteLine("Your birth year is {0}", YearOfBorn);
                Console.ReadLine();
            }
            catch (Age)
            {
                Console.WriteLine("An error occurred. Make sure to input positive and has no decimals.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Please contact support.");
                Console.ReadLine();
                return;
            }
        }
    }
}
