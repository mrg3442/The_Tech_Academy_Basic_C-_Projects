﻿using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}";
            Console.WriteLine(msg);

            string path = @"C:\Tech Academy Projects\The_Tech_Academy_Basic_C-_Projects\Basic_C#_Programs\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);


            double tScore = 0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach(string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length +  "student scores. \tAvergae score: " + avgScore);

            Console.WriteLine("\n\n\nPress any key to exit");
            Console.Read();
        }
    }
}
