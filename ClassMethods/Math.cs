using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
    //static class cannot be instantiated in program.cs
{
    public static class Math
    {   //divide method is considered overloaded b/c there are 2 set of instructions for the one method
        //void means cannot return anything
        public static void Divide(int numInput)
        {
            int numOutput = (numInput / 2);
            Console.WriteLine(numOutput);
            Console.ReadLine();
        }
        public static void Divide(string numInput)
        {
            int numOutput = (Convert.ToInt32(numInput) / 2);
            Console.WriteLine(numOutput);
            Console.ReadLine();
        }
        public static void Multiply(int numInput, out int numOutput2)
        {
             numOutput2 = 0;
             
        }
    }
}
