using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating const and var using keyword var
            const string name = "Matthew";
            var dictionary = new Dictionary<string, string>();
            //Creates instance of class but doesnt pass name so constructor chaining happens
            var test = new Class1();
            Console.WriteLine(test.Name);
            Console.Read();
            
        }
    }
}
