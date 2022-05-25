using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //creates string array
            string[] strArray = { "Bob", "Joe", "Charlie", "Jeff", "Matt" };
            //creates int array
            int[] intArray = { 1, 2, 3, 4, 5 };
            //------------------Begin of user program-----------------------------
            //Gets user input for which array pos 1-5 then subtracts 1 to get actual array position
            Console.WriteLine("Please select a array position of 1-5 for a string....\n");
            int strVar = Convert.ToInt16(Console.ReadLine());
            strVar--;
            //Prints to console array position
            Console.WriteLine("\nThe string you have selected is: \"" + strArray[strVar] + "\"");
            //Gets user input for int array pos 1-5 then subtracts 1 to get array position
            Console.WriteLine("\nPlease select a array position of 1-5 for a integer....\n");
            int intVar = Convert.ToInt16(Console.ReadLine());
            intVar--;
            //Prints to console array position
            Console.WriteLine("\nThe integer you have selected is: \"" + intArray[intVar] + "\"");


            Console.Read();
        }
    }
}
