using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature == roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            string usernumber;
            Console.WriteLine("Enter a number and it will be multipled by 50.");
            usernumber = Console.ReadLine();
            int userResult;
            userResult = (Convert.ToInt32(usernumber) * 50);
            Console.WriteLine("Your result is " + userResult);
            Console.ReadLine();


            string usernumber1;
            Console.WriteLine("Enter a number and 25 will be added to it.");
            usernumber1 = Console.ReadLine();
            int userResult1;
            userResult1 = (Convert.ToInt32(usernumber1) + 25);
            Console.WriteLine("Your result is " + userResult1);
            Console.ReadLine();


            string usernumber2;
            Console.WriteLine("Enter a number and it will be divided by 12.5");
            usernumber2 = Console.ReadLine();
            double userResult2;
            userResult2 = (Convert.ToInt32(usernumber2) / 12.5);
            Console.WriteLine("Your result is " + userResult2);
            Console.ReadLine();


            string usernumber3;
            Console.WriteLine("Enter a number that is greater than 50.");
            usernumber3 = Console.ReadLine();
            int userResult4;
            userResult4 = Convert.ToInt32(usernumber3);
            if (userResult4 > 50)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }

            string usernumber4;
            Console.WriteLine("Enter a number and it will be divided by 7 and then the remainder will be displayed.");
            usernumber4 = Console.ReadLine();
            double userResult5;
            userResult5 = (Convert.ToInt32(usernumber4) % 7);

            Console.WriteLine("Your result is " + userResult5);
            Console.ReadLine();




        }
    }
}
