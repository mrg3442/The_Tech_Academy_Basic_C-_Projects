using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 122, 222, 3452, 43452, 53452, 6894, 3242, 238, 94 };
                Console.Write("Please Input a number to divide each list item by...");
                int divideBy = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] = numbers[i] / divideBy;
                    Console.WriteLine("New number is...." + numbers[i]);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a number....");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot Divide by 0....");
            }
            finally
            {
                Console.WriteLine("The program has sucesfully completed the try catch block");
                Console.Read();
            }
           
        }
    }
}
