using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates employee w string parameter
            var operatorObj = new Employee<string>();
            operatorObj.things = new List<string> { "jesse", "rob", "bob" };
            //instantiates employee with int parameter
            var operatorObj2 = new Employee<int>();
            operatorObj2.things = new List<int> { 1, 2, 3 };
            
            //Loops through firt instance of employee the string list
            for(int i = 0;  i < operatorObj.things.Count; i++)
            {
                Console.WriteLine(operatorObj.things[i]);
            }

            //loops through second instance of employee the int list
            for (int i = 0; i < operatorObj2.things.Count; i++)
            {
                Console.WriteLine(operatorObj2.things[i]);
            }




            Console.Read();
        }
    }
}
