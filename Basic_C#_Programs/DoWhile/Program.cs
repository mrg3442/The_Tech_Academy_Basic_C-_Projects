using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = 0;
            short i = 1;
            while(n < 10) {
                n++;
                Console.WriteLine("Program Itteration: " + n);
                do
                    {
                    i++;
                    Console.WriteLine("I = " + i);
                    }
                while(i < 8) ;
                i = 0;
            }
            Console.Read();
        }
    }
}
