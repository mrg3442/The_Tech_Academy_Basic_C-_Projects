using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates Class1 
            var operatorObject = new Class1();
            //calls method from Class1
            var result = operatorObject.MathOperation(2);
            Console.WriteLine(result);
            //creates new instantiantion of class
            var operatorObject2 = new Class1();
            //uses overloaded method to do a decimal instead of int
            var result2 = operatorObject2.MathOperation(2.2m);
            Console.WriteLine(result2);
            // creates third instantiantion of Class1
            var operatorObject3 = new Class1();
            var result3 = operatorObject3.MathOperation("4");
            Console.WriteLine(result3);
            Console.Read();


        }
    }
}
