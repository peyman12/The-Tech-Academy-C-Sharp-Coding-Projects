using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
    class Program
    {
        static void Main(string[] args)
            {
                const int currentNumber = 2;
                Console.WriteLine("The current value is {0}", currentNumber);

                var previousNumber = new Number("That current value subtract 1 is ", 1);
                Console.WriteLine("The number before that is {0}", previousNumber.Num);
                Console.ReadLine();
            }
        
    }
}
