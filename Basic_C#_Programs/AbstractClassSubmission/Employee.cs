using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Employee : Person, IQuitable
    {
        public override void SayName()
        {
            Console.WriteLine("Hello " + FirstName + " " + LastName + "\n"
                + "Welcome to your first day on the job");
        }

        public void Quit()
        {
            Console.WriteLine("You have quit your job!");
        }
    }
}
