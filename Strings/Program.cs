using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string question = "How are you today?";
            string answer = "I am doing well";
            greeting = greeting.ToUpper();
            string statement = greeting +"\n"+ question + "\n" + answer;
            
            Console.WriteLine(statement);
            Console.ReadLine();

            StringBuilder guitar = new StringBuilder();
            guitar.Append("The guitar is a fretted musical instrument that usually has six strings. ");
            guitar.Append("It is typically played with both hands. ");
            guitar.Append("One can master it, but it takes patience and patience. ");
            guitar.Append("It is very rewarding.");

            Console.WriteLine(guitar);
            Console.ReadLine();

            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", Jesse.\nHello on a new line. \n \tHello on a tab. I want a backslash \\";
            //string fileName = @"C:\Users\Jesse";
            //// @ tells c# that there are no esc fcts being used
            //bool trueorFalse = name.Contains("s");
            //trueorFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Jesse");


            //Console.WriteLine(sb);
            //Console.ReadLine();

        }
    }
}
