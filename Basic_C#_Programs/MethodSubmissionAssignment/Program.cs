using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates class
            var operatorObject = new Class1();
            //asks user for first number
            Console.WriteLine("Please Input first Number");
            int num1 = Int32.Parse(Console.ReadLine());
            //asks user if they would like to input a second number
            Console.WriteLine("Would you like to input a second number please write true or false");
            bool second = Convert.ToBoolean(Console.ReadLine());
            var result = operatorObject.Method1(num1);
            //if users wants to input a second number grabs input and updates result var
            //so that it runs with num1 and num2 instead of just num1
            if (second)
            {
                Console.WriteLine("Input second number");
                int num2 = Int32.Parse(Console.ReadLine());
                result = operatorObject.Method1(num1, num2);
            }
            Console.WriteLine(result);
            Console.Read();

        }
    }
}
