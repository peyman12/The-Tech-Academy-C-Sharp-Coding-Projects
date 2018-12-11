using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandling
{
     public class Age : Exception
        {
            public Age()
               : base() { }
            public Age(String message)
                : base(message) { }
        }
}

