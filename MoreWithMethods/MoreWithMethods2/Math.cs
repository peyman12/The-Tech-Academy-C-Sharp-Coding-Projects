using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreWithMethods2
{
    class Math
    {
        public int Add(int numInput)
        {
            int numOutput = (numInput + 4);
            return numOutput;
        }
        // public int b/c answer is asked to be in integer
        public int Add1(double numInput2)
        {
            int numOutput2 = (Convert.ToInt32(numInput2) + 7);
            return numOutput2;
        }
        
        public int Add2(string stringInput)
        {
            int stringOutput = (Convert.ToInt32(stringInput) + 8);
            return stringOutput;
        }
    }
}
