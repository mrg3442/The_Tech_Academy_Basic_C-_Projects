using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates employee class which inherits from abstract class person 
            //then calls SayName method
            Employee sample = new Employee();
            sample.FirstName = "Sample";
            sample.LastName = "Employee";
            sample.SayName();
            Console.Read();
        }
    }
}
