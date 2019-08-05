using System;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string strRacerName;
            double dblWins, dblLoss;
            double dblTotalRaces;
            double dblDifference;
            double dblProduct;
            double dblQuotient;

            Console.WriteLine("This program calculates the number of races done.");
            Console.WriteLine("On you mark! Get SET! Goooooooo!");
            Console.WriteLine("");

            Console.WriteLine("Enter the racer's name: ");
            strRacerName = Console.ReadLine();

            //prompt for wins
            Console.WriteLine("Enter the racer's # of wins: ");
            dblWins = Convert.ToInt32(Console.ReadLine());

            //prompt for loss
            Console.WriteLine("Enter the racer's # of losses: ");
            dblLoss = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblTotalRaces = dblWins + dblLoss;
            dblDifference = dblTotalRaces - dblWins;
            dblProduct = dblWins * dblLoss;
            dblQuotient = dblTotalRaces / dblLoss;

            Console.WriteLine(strRacerName + "'s total races were " + dblTotalRaces);
            Console.WriteLine(strRacerName + "'s total difference was " + dblDifference);
            Console.WriteLine(strRacerName + "'s total races for the week " + dblProduct);
            Console.WriteLine(strRacerName + "'s total quotient was " + dblQuotient);

            Console.ReadLine();

        








        }
    }
}
