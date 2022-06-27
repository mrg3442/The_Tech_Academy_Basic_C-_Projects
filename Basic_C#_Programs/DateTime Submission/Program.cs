using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            //creates new datetime var named future then adds num to hours and prints to console
            DateTime future = DateTime.Now;
            future = future.AddHours(num);
            Console.WriteLine("In {0} hours it will be {1}", num, future);
            Console.Read();
        }
    }
}
