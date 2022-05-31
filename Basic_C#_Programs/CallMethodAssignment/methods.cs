using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethodAssignment
{
    public class Method
    {
        public int Multiply(int num)
        {
            num = num * num;
            return num;
        }

        public int Divide(int num)
        {
            num = num / 2;
            return num;
        }

        public int Add(int num)
        {
            num = num + num;
            return num;
        }
    }
}
