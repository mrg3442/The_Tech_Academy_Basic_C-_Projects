﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();


            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number + 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char randomLetter = 'k';
            char questionMark = '\u2103';
            decimal moneyInBank = 100.5m;
            double heightInCentimers = 211.304476;
            float secondsLeft = 6.24f;
            short temperatureOnMars = -341;
            string myName = "Jeff";


            int currentAge = 20;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = isRaining.ToString();

            Console.WriteLine(questionMark);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

        }
    }
}
