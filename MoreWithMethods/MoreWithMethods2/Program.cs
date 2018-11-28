using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreWithMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mymathbook1 = new Math();
            Console.WriteLine("Input your first number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your result is: " + mymathbook1.Add(userInput));

            Console.WriteLine("Input your second number");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your result is: " + mymathbook1.Add1(userInput2));

            Console.WriteLine("Input your second number");
            string userInput3 = Console.ReadLine();
            Console.WriteLine("Your result is: " + mymathbook1.Add2(userInput3));


            Console.ReadLine();

        }
    }
}
