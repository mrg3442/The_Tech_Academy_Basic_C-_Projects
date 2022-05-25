using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates array named names
            string[] names = { "", "", "", "" };
            Console.WriteLine("Please input four names...\n");
            //loops through array names and uses user input for each array position to update it
            for (int i = 0; i < names.Length; i++)
            {
                //var n takes i and adds 1 so it starts with name "1"
                int n = i + 1;
                Console.WriteLine("Please Input name number " + n + "\n");
                //gets user input assigns to var updatedName and then updates array
                string updatedName = Console.ReadLine();
                names[i] = updatedName;
                Console.WriteLine("\n");
            }

            //Prints out array names with updated values
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //fixed infinite loop
            int j = 1;
            while(j < 10){
                Console.WriteLine(j);
                j++;
            }

            //Loop using < 
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }

            //Loop using <=
            j = 50;
            while(j <= 100)
            {
                j = j * 2;
                Console.WriteLine(j);
            }
            

            //unique items string array
            string[] unique = { "Sarah", "Anya", "Bill" };
            //asks user to input a string to search for from unique
            Console.WriteLine("\n\n\n\n\nPlease provide a string to search for\n");
            string searchUnique = Console.ReadLine();
            //creates bool to check if on list
            bool onList = false;
            //iterates through array and returns the string inputed if it is in array unique
            for (int i = 0; i < unique.Length; i++)
            {
                if(searchUnique == unique[i])
                {
                    Console.WriteLine("\n" + unique[i]);
                    onList = true;
                    break;
                }
            }
            //if input was not in unique displays this

            if(!onList)
            {
                Console.WriteLine("Your input was not on the list.");
            }

            //resets onList to false
            onList = false;
            //creates two  string arrays with an identical name
            string[] str1 = {"Joe", "Red", "Tob", "Ted" };
            string[] str2 = {"Matt", "Ted", "Joe", "Tob" };
            //asks for user input 
            Console.WriteLine("Please provide a string input");
            string matching = Console.ReadLine();
            //loops through arrays to find matching indexs
            for(int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == matching)
                {
                    for (int k = 0; k < str2.Length; k++)
                    {
                        if (str2[k] == str1[i])
                        {
                            Console.WriteLine("\nFirst Array Position: " + i + "\n" +
                                "Second Array Position: " + k);
                            onList = true;
                        }
                    }
                }
            }
            //if input was not in both arrays displays this

            if (!onList)
            {
                Console.WriteLine("Your input was not on both lists.");
            }


            //creates a list of strings with one identical pair
            List<string> nameList = new List<string>() { "Joe", "Red", "Tob", "Ted", "Joe"};
            //foreach to loop thru list
            //var to track index position
            int index1 = 0;
            //var to track for matching index
            int index2 = 0;

            foreach (string name in nameList)
            {
                //reset second index tracker
                index2 = 0;
                //var to keep track of same string
                bool same = false;
                //loops through list and if name == name1 sets same to true
                foreach(string name1 in nameList)
                {
                    if(name == name1)
                    {
                        if(index1 != index2)
                        {
                            same = true;
                        }
                    }
                    index2++;
                }
                //if same == true print this string is on the list already!
                if (same)
                {
                    Console.WriteLine("The string: " + name + " is on the list already!");
                }
                index1++;
            }
         

            Console.Read();
        }
    }
}
