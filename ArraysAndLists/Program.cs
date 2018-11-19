using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {

        string[] strArray = { "Tyler", "Jeff", "John", "Glen", "Don" };
        Console.WriteLine("Select a index number between 0 and 4 to Select from the following array { Tyler, Jeff, John, Glen, Don }");
        string userinput1 = Console.ReadLine();
        if (userinput1 == "0")
        {
            Console.WriteLine(strArray[Convert.ToInt32(userinput1)]);
            Console.ReadLine();
        }
        else if (userinput1 == "1")
        {
            Console.WriteLine(strArray[Convert.ToInt32(userinput1)]);
            Console.ReadLine();
        }

        else if (userinput1 == "2")
        {
            Console.WriteLine(strArray[Convert.ToInt32(userinput1)]);
            Console.ReadLine();
        }
        else if (userinput1 == "3")
        {
            Console.WriteLine(strArray[Convert.ToInt32(userinput1)]);
            Console.ReadLine();
        }

        else if (userinput1 == "4")
        {
            Console.WriteLine(strArray[Convert.ToInt32(userinput1)]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Insert a proper input");
            Console.ReadLine();
        }

        int[] intArray = { 11, 15, 19, 114, 200 };
        Console.WriteLine("Insert a number between 0 and 4 to select from the following array: {11, 15, 19, 114, 200}");
        string userinput2 = Console.ReadLine();
        if (userinput2 == "0")
        {
            Console.WriteLine(strArray[Convert.ToInt32(userinput2)]);
            Console.ReadLine();
        }
        else if (userinput2 == "1")
        {
            Console.WriteLine(strArray[Convert.ToInt32(userinput2)]);
            Console.ReadLine();
        }

        else if (userinput2 == "2")
        {
            Console.WriteLine(strArray[Convert.ToInt32(userinput2)]);
            Console.ReadLine();
        }
        else if (userinput2 == "3")
        {
            Console.WriteLine(strArray[Convert.ToInt32(userinput2)]);
            Console.ReadLine();
        }

        else if (userinput2 == "4")
        {
            Console.WriteLine(strArray[Convert.ToInt32(userinput2)]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Insert a proper input");
            Console.ReadLine();
        }

        List<string> newList = new List<string>();
        newList.Add("A");
        newList.Add("B");
        newList.Add("C");
        newList.Add("D");
        newList.Add("E");
        Console.WriteLine("Select a index number between 0 and 4 to Select from the following llist { A, B, C, D, E }");
        string userinput3 = Console.ReadLine();
        Console.WriteLine(newList[Convert.ToInt32(userinput3)]);
        Console.ReadLine();
    }
        
        

        //int[] intArray = { 1, 5, 9, 14, 200 };
        //Console.WriteLine("Select a index number between 0-4");
        //string userinput2 = Console.ReadLine();
        //Console.WriteLine(intArray[Convert.ToInt32(userinput2)]);
        //Console.ReadLine();




        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Jesse");
        //intList.Remove("Jesse");



        //Console.WriteLine(intList[0]);
        //Console.ReadLine();



        //    int[] numArray = new int[5];
        //    numArray[0] = 5;
        //    numArray[1] = 2;
        //    numArray[2] = 10;
        //    numArray[3] = 200;
        //    numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        ////below is the fastest way to creat an array
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;


        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();



    }
    

