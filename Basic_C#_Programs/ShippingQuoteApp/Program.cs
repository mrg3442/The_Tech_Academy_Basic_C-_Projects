using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Gets user input for package weight
            Console.WriteLine("\nPlease provide your package weight below: \n");
            decimal packWeight = Convert.ToDecimal(Console.ReadLine());
            //Determines if package is approiate weight and notifies user
            string shippable = packWeight < 40 ? "\nYour package can be shipped." : "\nPackage too heavy to be shipped via Package Express. Have a good day.";
            Console.WriteLine(shippable);
            if(shippable == "Package cannot be shipped.")
            {
                Environment.Exit(0);
            }
            //gets package width, height, and length from user
            Console.WriteLine("\nPlease Provide Package Width: \n");
            decimal packWidth = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nPlease Provide Package Height: ");
            decimal packHeight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nPlease Provide Package Lenght: ");
            decimal packLength = Convert.ToDecimal(Console.ReadLine());
            //Adds all package dimensions together and then determines if to big and notifies user
            if(packHeight + packLength + packWidth > 40)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if(packHeight + packLength + packWeight < 40)
            {
                Console.WriteLine("Package can be shipped.");
            }
            //Adds all dimensions together then calculates cost and then gives to user
            decimal quote = (packWidth + packLength + packHeight) * packWeight / 100;
            Console.WriteLine("\nYour estimated total for shipping this package is: $" + quote);
            Console.ReadLine();
        }
    }
}
