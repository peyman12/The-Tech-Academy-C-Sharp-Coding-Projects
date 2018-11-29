using System;
using AbstractMethods;
using AbstractClasses;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods
{
    public  class Employee : Person
    {  
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
        
    }
}
