using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethodAssignment
{
    public class Method
    {
        //multiplies num by itself
        public int Multiply(int num)
        {
            num = num * num;
            return num;
        }
        //Divides num in half
        public int Divide(int num)
        {
            num = num / 2;
            return num;
        }
        //Adds num to itself
        public int Add(int num)
        {
            num = num + num;
            return num;
        }
    }
}
