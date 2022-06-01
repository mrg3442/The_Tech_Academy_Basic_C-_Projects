using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethodSubmissionAssignment
{
    class Class1
    {
        //Multiplys num by itself
        public  int MathOperation(int num)
        {
            num = num * num;
            return num;
        }
        // second overload does same as first method but if decimal
        public decimal MathOperation(decimal num)
        {
            num = num * num;
            return num;
        }
        //third overloaded method takes string converts to int and does num to the power of 3
        public int MathOperation(string num)
        {
            int integer = Int32.Parse(num);
            integer = integer * integer * integer;
            return integer;


        }
    }
}
