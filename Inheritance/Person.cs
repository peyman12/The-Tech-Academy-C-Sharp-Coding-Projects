using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        //these are properties aka object variables with get post functionality
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public  void SayName()
        {
            
            Console.WriteLine("Name: " + FirstName + LastName);
            Console.ReadLine();
        }
        
        

        
    }
}
