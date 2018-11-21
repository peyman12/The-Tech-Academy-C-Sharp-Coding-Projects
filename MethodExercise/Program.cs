using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mymathbook1 = new Math();


            Console.WriteLine("What number do you want to add 1 to?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your result is " + mymathbook1.Addition(userInput));
            

            Console.WriteLine("What number do you want subtract 1 from?");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your result is " + mymathbook1.Subtraction(userInput));
            

            Console.WriteLine("What number do you want to muiltple 1 to?");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your result is " + mymathbook1.Multiply(userInput));
            Console.ReadLine();
        }

    }
}
