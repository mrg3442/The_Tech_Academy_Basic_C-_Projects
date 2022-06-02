using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //gets user input to pass to method1
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            //prints method one result to console
           Class1.Method1(num);

            //creating two local vars for out variables
            int result;
            int result2;
            //Calling op object method2 to get out vars
            Class1.Method2(out result, out result2);
            //Printing to console the out vars
            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.Read();
        }
    }
}
