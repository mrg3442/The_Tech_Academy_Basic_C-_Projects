using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate class
            var operatorObject = new Class1();
            //calls method and specifies parameters by name
            operatorObject.Method1(num1: 2, num2: 2);
            Console.Read();
        }
    }
}
