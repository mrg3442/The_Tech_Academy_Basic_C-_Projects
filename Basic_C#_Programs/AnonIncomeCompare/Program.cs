using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonIncomeCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //-------------------------------------------First Person Details----------------------------------------------------------
            Console.WriteLine("Please Enter Details for Person 1 \n" +
                "Hourly Rate: \n");
            string firstHourly = Console.ReadLine();
            Console.WriteLine("\nHours worked per weak \n");
            string firstWorked = Console.ReadLine();
            Decimal firstRate = Convert.ToDecimal(firstHourly);
            int firstHours = Convert.ToInt16(firstWorked);
            Console.WriteLine("First Person Worked " + firstHours + " hours at a rate of $" + firstRate + "\n \n");
            //-------------------------------------------Second Person Details---------------------------------------------------------
            Console.WriteLine("Please Enter Details for Person 2 \n" +
                "Hourly Rate: \n");
            string secondHourly = Console.ReadLine();
            Console.WriteLine("\nHours worked per weak \n");
            string secondWorked = Console.ReadLine();
            Decimal secondRate = Convert.ToDecimal(secondHourly);
            int secondHours = Convert.ToInt16(secondWorked);
            Console.WriteLine("First Person Worked " + secondHours + " hours at a rate of $" + secondRate);
            //-------------------------------------------Math Operations---------------------------------------------------------------
            int secondSalary = (int)(secondRate * secondHours * 52);
            int firstSalary = (int)(firstRate * firstHours * 52);
            bool firstMore;
            if (firstSalary > secondSalary)
            {
                firstMore = true;
            } else
            {
                firstMore = false;
            }
            //--------------------------------------------------Final Output--------------------------------------------------------------------
            Console.WriteLine("\n\n\nAnnual Salary of Person 1: $" + firstSalary);
            Console.WriteLine("\nAnnual Salary of Person 2: $" + secondSalary);
            Console.WriteLine("\n\nDoes Person 1 make more than Person 2? \n" + firstMore);
            Console.ReadLine();
        }
    }
}
