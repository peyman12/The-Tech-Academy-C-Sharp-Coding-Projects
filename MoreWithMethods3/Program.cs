using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreWithMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mybook1 = new Math();
            Console.WriteLine("Input a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number if you'd like.");
            string userInput2 = Console.ReadLine();

            

            if (userInput2 == "")
            {
                int userOutput = mybook1.Add(userInput);

                Console.WriteLine(userOutput);
            }
           else
            {
                int userOutput = mybook1.Add(userInput, Convert.ToInt32(userInput2));

                Console.WriteLine(userOutput);
            }
            
            Console.ReadLine();
            
            

            
        }
    }
}
