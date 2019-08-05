using System;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double dblFirstNumber;
            double dblSecondNumber;
            double dblThirdNumber;

            //user input
            Console.WriteLine("Enter your first number: ");
            dblFirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            dblSecondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third number: ");
            dblThirdNumber = Convert.ToInt32(Console.ReadLine());

        }
    }
}
