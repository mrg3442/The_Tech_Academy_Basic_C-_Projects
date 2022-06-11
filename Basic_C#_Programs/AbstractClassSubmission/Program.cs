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
            //creates object of IQuitable type then calls Quit Method
            Employee sample2 = new Employee();
            sample2.FirstName = "Sample";
            sample2.LastName = "Employee";
            sample2.Quit();

            Console.Read();
        }
    }
}
