using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseEnumSubmission
{
    public enum days
    {
        Monday,
        Tuesday,
        Wed,
        Thursday,
        Friday
    }
    class Program
    {
        static void Main(string[] args)
        {
            //gets userinput for prompt then goes through a try catch block 
            //Try parses through enum days and if not valid asks user to input
            //a valid day of the week.
            Console.WriteLine("Please enter the day of the week");
            string currentDay = Console.ReadLine();
            
            try
            {
                days day = (days)Enum.Parse(typeof(days), currentDay);
                Console.WriteLine(day);
            }
            catch
            {
                Console.WriteLine("Please enter a actual day of the week");
            }

            Console.Read();
        }
    }
}
