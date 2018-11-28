using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            
            int numInput = Convert.ToInt32(Console.ReadLine());
            Math.Divide(numInput);

            
            
        }
    }
}
