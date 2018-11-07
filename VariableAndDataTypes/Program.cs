using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemperature = -23;
            //char questionMark = '\u2103';

            //decimal moneyInBank = 100.5m;

            //short temperatureOnMars = -341;

            //string myName = "Jesse";

            //double heightInCEntimeters = 211.30202092;

            //float secondsLeft = 2.62f;

            //int currentAge = 30;
            //string yearsOld = currentAge.ToString();

            //bool isRaining = true;
            //string rainingStatus = Convert.ToString(isRaining);
            //Console.WriteLine(rainingStatus);
            //Console.ReadLine();


            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string currentPage = Console.ReadLine();
            int currentNum = Convert.ToInt32(currentPage);


            Console.WriteLine("Do you need help with anything? Please answer " + "\"" + "true" + "\"" + " or " + "\"" + "false" + "\"" + ".");
            string needHelp = Console.ReadLine();
            bool responseHelp = Convert.ToBoolean(needHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific.");
            string currentFeedback = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int numberStudied = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
