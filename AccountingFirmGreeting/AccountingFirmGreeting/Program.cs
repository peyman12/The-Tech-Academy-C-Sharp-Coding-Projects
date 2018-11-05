using System;


namespace AccountingFirmGreeting
{
    class Program
    {
        static void Main()
        {
            String str = @"""accounting""";
            Console.WriteLine("Welcome to Acme Accounting Systems");
            
            Console.WriteLine("Remember, we're " + str + " on you !");
            Console.Read();
        }
    }
}
