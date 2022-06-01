using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Class1
    {
        //adds num1 and num2 together num2 is set to default of 2
        public int Method1(int num1, int num2 = 2)
        {
            int num3 = num1 + num2;
            return num3;
        }
    }
}
