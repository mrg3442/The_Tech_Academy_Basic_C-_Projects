using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\n" +
                "Student Daily Report.\n" +
                "What is your name?");
            //This section grabs the name
            string name = "Your name is: " + Console.ReadLine();
            // this section grabs course name
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            //this section grabs page number as a string then convers to a short
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            int pageNum = Convert.ToInt16(page);
            //This sections grabs true or false as string then convers to a bool
            Console.WriteLine("Is there anything you need help with?");
            string help = Console.ReadLine();
            bool helpStatus = Convert.ToBoolean(help);
            //Sections grabs positive experiences
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string exp = Console.ReadLine();
            //This section grabs any other feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            //This section grabs how many hours studies as string then convers to int
            Console.WriteLine("How many hours did you study today?");
            string study = Console.ReadLine();
            int hours = Convert.ToInt16(study);
            //-------------------------------------------------------LAST PART OF PROGRAM---------------------------------------------------
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
