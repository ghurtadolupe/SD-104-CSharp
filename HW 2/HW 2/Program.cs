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

            //Finding the highest number from the two
            if (dblFirstNumber > dblSecondNumber)
            {
                Console.WriteLine("Your highest number is " + dblFirstNumber);

            }
            else if (dblFirstNumber < dblSecondNumber)
            {
                Console.WriteLine("Your highest number is " + dblSecondNumber);
            }


            Console.WriteLine("Enter your third number: ");
            dblThirdNumber = Convert.ToInt32(Console.ReadLine());

           //Finding the highest number from the three

            if (dblThirdNumber > dblFirstNumber && dblThirdNumber > dblSecondNumber)
            {
                Console.WriteLine("Your biggest number is actually "+ dblThirdNumber);
            }

            else if(dblSecondNumber > dblFirstNumber && dblSecondNumber > dblThirdNumber)
            {
                Console.WriteLine("Your biggest number is actually " + dblSecondNumber);
            }

            else if (dblFirstNumber > dblSecondNumber && dblFirstNumber > dblThirdNumber)
            {
                Console.WriteLine("Your biggest number is actually " + dblFirstNumber);
            }


            //Finding the lowest number

            if (dblFirstNumber < dblSecondNumber && dblFirstNumber < dblThirdNumber)
            {
                Console.WriteLine("The lowest number was " + dblFirstNumber);
            }

            else if (dblSecondNumber < dblFirstNumber && dblSecondNumber < dblThirdNumber)
            {
                Console.WriteLine("The lowest number was " + dblSecondNumber);
            }

            else if (dblThirdNumber < dblFirstNumber && dblThirdNumber < dblSecondNumber)
            {
                Console.WriteLine("The lowest number was " + dblThirdNumber);
            }





            Console.ReadLine();


        }
    }
}
