
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignSubmission
{

    public struct Number
    {
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number test = new Number();
            test.Amount = 2.34m;

            Console.WriteLine(test.Amount);
            Console.Read();
        }
    }
}
