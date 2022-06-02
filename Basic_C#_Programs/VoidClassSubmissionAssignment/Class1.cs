using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidClassSubmissionAssignment
{
    static class Class1
    {
        //void method takes num and divides by two then prints to console
        public static void Method1(int num1)
        {
            num1 = num1 / 2;
            Console.WriteLine(num1);
        }
        //Method using two out parameters.
        public static void Method2(out int result, out int result2)
        {
            int num1 = 9;
            int num2 = 4;
            result = num1;
            result2 = num2;
        }
        //Overloaded method2 to get two doubles instead of ints
        public static void Method2(out double result, out double result2)
        {
            double num1 = 9;
            double num2 = 4;
            result = num1;
            result2 = num2;
        }
    }
}
