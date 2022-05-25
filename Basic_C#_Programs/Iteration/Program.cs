using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testscores = { 98, 99, 95, 70, 80, 24, 40, 91, 66, 86, 84 };

            //for (int i = 0; i < testscores.Length; i++)
            //{
            //    if(testscores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testscores[i]);
            //    }
            //}
            //Console.Read();

            //string[] names = { "Jesse", "Eric", "Daniel", "Adam" };

            //for(int i = 0; i < names.Length; i++)
            //{
            //    if(names[i] == "Jesse")
            //    {
            //        Console.WriteLine(names[i]);
            //    }
            //}
            //Console.Read();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(77);
            //testScores.Add(72);
            //testScores.Add(86);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.Read();

            //List<string> names = new List<string>() { "Jesse", "Eric", "Daniel", "Adam" };

            //foreach (string name in names)
            //{
            //    if(name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.Read();

            List<int> testScores = new List<int>();
            List<int> passingScores = new List<int>();
            testScores.Add(98);
            testScores.Add(99);
            testScores.Add(77);
            testScores.Add(72);
            testScores.Add(86);

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score); 
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.Read();
        }
    }
}
