using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Input a statement. It will be logged and a file will be created on this computer.");
                string text = Console.ReadLine();
                File.WriteAllText("C:\\Users\\User\\Documents\\Visual Studio 2017\\fileio.txt", text);
                string fileRead = File.ReadAllText("C:\\Users\\User\\Documents\\Visual Studio 2017\\fileio.txt");
                Console.WriteLine("Statement logged: " + " " + fileRead);
                Console.ReadLine();
            }
        }
    }
}
