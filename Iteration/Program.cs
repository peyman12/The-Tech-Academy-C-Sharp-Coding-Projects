using System;
using System.Collections.Generic;



    class Program
    {
    static void Main(string[] args)
    {
        //1.
        //string[] nameList = { "Bob", "Mark", "Jeff", "Brad"};
        //Console.WriteLine("Input some text");
        //string textInput = Console.ReadLine();
        //for(int i = 0; i < nameList.Length; i++)
        //{
        //    Console.WriteLine(nameList[i] + " " + textInput);

        //}
        //Console.ReadLine();

        //2. infinite loop
        //for (int j = 0; ; j++)
        //{
        //    while (true)
        //        Console.WriteLine(j++);
        //    Console.ReadLine();
        //}


        //3. this loop now counts by 1 only when the user presses enter
        //for (int j = 0; ; j++)
        //{

        //    Console.WriteLine(j);
        //    Console.ReadLine();
        //}

        //4. user hits enter until 4 then program closes
        //Console.WriteLine("Press enter 3 times");

        //for (int k = 0; k < 4; k++)
        //{
        //    Console.WriteLine(k);
        //    Console.ReadLine();
        //}

        ////5.
        //Console.WriteLine("Press enter 4 times");
        //for (int l = 0; l <= 4; l++)
        //{
        //    Console.WriteLine(l);
        //    Console.ReadLine();
        //}

        //6. 7. 8.
        //List<string> studentNames = new List<string>();
        //studentNames.Add("doug");
        //studentNames.Add("brad");
        //studentNames.Add("rose");
        //studentNames.Add("mary");
        //studentNames.Add("ralph");
        //Console.WriteLine("Enter text that matches in the list.");
        //string input = Console.ReadLine().ToLower();


        //bool mybool = false;
        //foreach (string names in studentNames)
        //{
        //    if (input == names)
        //    {
        //        mybool = true;
        //        Console.WriteLine(studentNames.IndexOf(names));
        //        Console.ReadLine();
        //    }
            
        //}
        //if (mybool == false)
        //{
        //    Console.WriteLine("Input is not in the list.");
        //    input = Console.ReadLine();
        //}

        //9. 10.
        //List<string> studentNames2 = new List<string>();
        //studentNames2.Add("doug");
        //studentNames2.Add("doug");
        //studentNames2.Add("rose");
        //studentNames2.Add("mary");
        //studentNames2.Add("ralph");
        //Console.WriteLine("Enter text that matches in the list.");
        //string input2 = Console.ReadLine().ToLower();
        //bool mybool2 = false;

        //while (!mybool2)
        //    {
        //    for (int i = 0; i < studentNames2.Count; i++)
        //    {
        //        if (studentNames2[i].Contains(input2))
        //        {
        //            mybool2 = true;
        //            Console.WriteLine(i);
                    
        //        }

        //    }
        //    if (mybool2 == false)
        //    {
        //        Console.WriteLine("Input is not in the list.");
        //        input2 = Console.ReadLine();
        //    }
        //    Console.ReadLine();
        //}

        //11.
        List<string> studentNames3 = new List<string>();
        studentNames3.Add("doug");
        studentNames3.Add("doug");
        studentNames3.Add("rose");
        studentNames3.Add("mary");
        studentNames3.Add("ralph");
        Console.WriteLine("Enter text that matches in the list.");
        string input3 = Console.ReadLine().ToLower();
        List<string> studentNames4 = new List<string>();


        bool mybool3 = false;
        foreach (string names in studentNames3)
        {
            if (studentNames4.Contains(names))
            {
                mybool3 = true;
                Console.WriteLine(names + " has already appeared in the list.");
                
            }
           else
            {
                Console.WriteLine(names + " is new to the list.");

            }
            studentNames4.Add(names);
        }
        Console.ReadLine();
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for(int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++)


        //    {
        //        Console.WriteLine(names[j]);
        //    }

        //Console.ReadLine();


        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score:" + score);
        //    }
        //}
        //Console.ReadLine();


        //List<string> names = new List<string>() { "Jesse", "Erik", "Daniel", "Adam" };

        //foreach (string name in names)


        //    {
        //        Console.WriteLine(name);
        //    }

        //Console.ReadLine();

        //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        //List<int> passingScores = new List<int>();

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}
        //Console.WriteLine(passingScores.Count);
        //Console.ReadLine();

    }
}

