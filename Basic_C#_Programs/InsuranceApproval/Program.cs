using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Insuance approval process!\n" +
                "Please provide your age\n");
            //Gets age and converts to short
            string appAge = Console.ReadLine();
            short age = Convert.ToInt16(appAge);
            //gets dui and convers to bool
            Console.WriteLine("\nHave you ever had a dui? Please Provide answer in form of\n" +
                "\"true\" or \"false\"\n");
            string getDui = Console.ReadLine();
            bool dui = Convert.ToBoolean(getDui);
            //gets speeding ticket number and convers to int
            Console.WriteLine("\nOkay Last Step! How many speeding tickets do you have?\n" +
                "Please answer in the form of a number example \"3\" or \"1\"\n");
            string speedTickNum = Console.ReadLine();
            short tickNumber = Convert.ToInt16(speedTickNum);
            //Checks if eligble to be insured
            if (age >= 18 && dui == false && tickNumber <= 3)
            {
                Console.WriteLine("Congratulations you're approved and a agent will reach out to you soon!");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("We are sorry at this time we cannot approve you for insurance.");
                Console.ReadLine();
            }

        }
    }
}
