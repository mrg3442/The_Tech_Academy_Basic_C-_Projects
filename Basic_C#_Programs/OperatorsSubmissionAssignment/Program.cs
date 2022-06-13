using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates two instances of employee then deterimines if obj id are equal then tells user if they are or not.
            var operatorObj = new Employee();
            operatorObj.ID = 22;

            var operatorObj2 = new Employee();
            operatorObj2.ID = 22;

            if(operatorObj == operatorObj2)
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are not the same");
            }
            Console.Read();
        }
    }
}
