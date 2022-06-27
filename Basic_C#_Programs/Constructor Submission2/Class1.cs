using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission2
{
    class Class1
    {
        public Class1(): this("Matt") { }
        public Class1(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
