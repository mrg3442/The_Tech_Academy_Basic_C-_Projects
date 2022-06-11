using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Hello " + FirstName + " " + LastName + "\n"
                + "Welcome to your first day on the job");
        }
    }
}
