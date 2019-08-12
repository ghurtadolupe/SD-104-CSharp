using System;

namespace Lab_6_Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Declarations
                int nYear;
                bool isDiv4;
                bool isDiv100;
                bool isDiv400;

                //validate year input
                do
                {
                    Console.WriteLine("Please Enter a Year to see if it was or will be a leap year: ");
                } while (!int.TryParse(Console.ReadLine(), out nYear));

                //calculate factors
                isDiv4 = nYear % 4 == 0 ? true : false;
                isDiv100 = nYear % 100 == 0 ? true : false;
                isDiv400 = nYear % 400 == 0 ? true : false;

                //compound test to see if nYear is a leap year
                if ((isDiv4 && isDiv100 && isDiv400) || (isDiv4 && !isDiv100 && !isDiv400))
                {
                    Console.WriteLine(nYear + " is a leap year.");
                }
                else
                {
                    Console.WriteLine(nYear + " is not a leap year.");
                }

                Console.WriteLine("Would you like to test another year? Type Y for Yes or any other key to quit");
            } while (Console.ReadLine() == "Y");
        } 
    }
}
