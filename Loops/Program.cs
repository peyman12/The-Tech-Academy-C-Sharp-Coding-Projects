using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //while statement
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;
            }
            Console.ReadLine();
            //do while statement

            int j = 0;

            do
            {
                Console.WriteLine("Value of j: {0}", j);

                j++;

            } while (j < 55);
            Console.ReadLine();

            //Console.WriteLine("Guess a number?");
            //int number = Convert.ToInt32(Console.ReadLine());

            //bool isGuessed = false;

            //while (!isGuessed)
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed 12. That is correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //Console.Read();
        }
    }
}
