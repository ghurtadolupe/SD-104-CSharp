using System;

/*
Project:    Lab 2 Calculate Batting Average
Date:        to/da/y
Author:     You the big new programmer
Notes:      This program reads in a baseball player's name,
            number of hits and number of at bats.
            The player's batting average is calculated and displayed
*/

        

class Program
    {
        static void Main(string[] args)
        {

            //variable declaration
            string strPlayerName;
            double dblHits, dblAtBats;
            double dblBattingAverage;


            Console.WriteLine("This program calculates a baseball player's batting average.");
            Console.WriteLine("<------------------------------------------>");
            Console.WriteLine(""); //we will learn other ways to do this i console programs
            Console.WriteLine("Enter the player's name: ");
            strPlayerName = Console.ReadLine();

        //prompt for hits
        Console.WriteLine("Enter the player's #of hits: ");
        dblHits = Convert.ToInt32(Console.ReadLine());

        //prompt for batts
        Console.WriteLine("Enter the player's #of at bats: ");
       dblAtBats = Convert.ToInt32(Console.ReadLine());

        //calculation
        dblBattingAverage = dblHits / dblAtBats;
        Console.WriteLine(strPlayerName + "'s batting average is " + dblBattingAverage);
        Console.ReadLine();








    }
    }

