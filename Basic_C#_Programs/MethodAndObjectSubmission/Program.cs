using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjectSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiates new employee class then calls SayName Method
            Employee Sample = new Employee();
            Sample.FirstName = "Sample";
            Sample.LastName = "Student";
            Sample.SayName();
            //Read Console
            Console.Read();
        }
    }
}
