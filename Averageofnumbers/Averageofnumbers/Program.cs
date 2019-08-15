using System;

namespace Averageofnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string strPlayerName;
            double dblfirstnumber, dblsecondnumber;
            double dblAverage;


            Console.WriteLine("This program calculates an average.");
            Console.WriteLine("<------------------------------------------>");
            Console.WriteLine(""); //we will learn other ways to do this i console programs
            Console.WriteLine("Enter the player's name: ");
            strPlayerName = Console.ReadLine();

            //prompt for hits
            Console.WriteLine("Enter the player's first number: ");
            dblfirstnumber = Convert.ToInt32(Console.ReadLine());

            //prompt for batts
            Console.WriteLine("Enter the player's second number: ");
            dblsecondnumber = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblAverage = dblfirstnumber / dblsecondnumber;
            Console.WriteLine(strPlayerName + "'s average is  " + dblAverage);


            //determine if its higher than a number. for example the number 25
            if (dblAverage > 25)
            {
                Console.WriteLine(dblAverage + " is greater than 25");

            }
            else if (dblAverage < 25)
            {
                Console.WriteLine(dblAverage + " is lower than 25");
            }







            Console.ReadLine();












        }
    }
}
