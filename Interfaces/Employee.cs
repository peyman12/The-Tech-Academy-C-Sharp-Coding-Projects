using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    
    
        public class Employee : Person, IQuittable
        {
            public override void SayName()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
            public void Quit()
            {
                Console.WriteLine("I, " + FirstName + " " +
                    LastName + ", do hereby Quit!");
            }
        }
    }

