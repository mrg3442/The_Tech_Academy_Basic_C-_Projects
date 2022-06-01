using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input for num to perform methods on
            Console.WriteLine("What number would you like to do math operations on? \n");
            int num = Convert.ToInt32(Console.ReadLine());
            //creates obj so methods can be called
            var operatorObject = new Method();
            //calls multiply method
            var result = operatorObject.Multiply(num);
            //calls divide method
            result = operatorObject.Divide(result);
            //calls add method
            result = operatorObject.Add(result);
            //prints to user num after all 3 methods were called
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
