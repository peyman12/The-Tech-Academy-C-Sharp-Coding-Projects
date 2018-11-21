using System;
using System.Collections.Generic;



class Program
    {
    static void Main(string[] args)
    {



        List<int> numberList = new List<int>();
        numberList.Add(0);
        numberList.Add(1);
        numberList.Add(2);
        numberList.Add(4);
        numberList.Add(4);
        Console.WriteLine("Enter a number to be divided by all numbers in the list.");

        try
        {
            int input = Convert.ToInt32(Console.ReadLine());
            foreach (int numbers in numberList)
            {
                double result = (input / numbers);
                Console.WriteLine("Your solutions = " + result);


            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please do not divide by zero");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");

        }
        finally
        {
            Console.ReadLine();
        }
    }

        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number.");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " +  numberThree);
        //    Console.ReadLine();
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Please type a whole number");
        //    return;
        //}


        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please do not divide by zero");

        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine();
        //}

    }
    

