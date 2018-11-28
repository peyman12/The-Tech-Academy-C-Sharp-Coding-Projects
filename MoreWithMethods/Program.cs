using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            Math mymathbook1 = new Math();

            //these are 2 diffrent examples that run through the math method creating 4 results
            mymathbook1.Add(2, 3);
            mymathbook1.Add(num1: 3, num2: 7);
            Console.ReadLine();
        }
    }
}
