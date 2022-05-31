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
            Console.WriteLine("What number would you like to do math operations on? \n");
            int num = Convert.ToInt32(Console.ReadLine());
            var operatorObject = new Method();
            var result = operatorObject.Multiply(num);
            result = operatorObject.Divide(result);
            result = operatorObject.Add(result);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
