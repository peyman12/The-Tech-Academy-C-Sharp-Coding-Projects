using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
    class Number
    {
        public string Name { get; set; }
        public int Num { get; set; }

        public Number(string name, int num)
        {
            Name = name;
            Num = num;
        }
        public Number() : this("Subtracting 1 is from 2 is", 1)
        {
        }
    }
}

