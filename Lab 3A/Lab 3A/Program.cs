using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double dblHeight;
            double dblWeight;
            double dblBMI;

            //user input
            Console.WriteLine("Enter your Height in inches: ");
            
            //validate
            while(!double.TryParse(Console.ReadLine(),out dblHeight) || dblHeight < 0)
            {
                Console.WriteLine("Not Valid. Must be positive rational number.");
            }

            //user input
            Console.WriteLine("Enter you Weight in pounds: ");
            //validate
            while (!double.TryParse(Console.ReadLine(), out dblWeight) || dblWeight < 0)
            {
                Console.WriteLine("Not Valid. Must be positive rational number.");
            }



            //calculations
            dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);




            //issue result and message
            Console.WriteLine("Your BMI is " + dblBMI);

            if (dblBMI < 18.5)
            {
                Console.WriteLine("BMI < 18.5 - Underweight");
            }
            else if (dblBMI <= 24.9)
            {
                Console.WriteLine("BMI between 18.5 and 24.9 - Normal");
            }
            else if (dblBMI <= 29.9)
            {
                Console.WriteLine("BMI between 25 and 29.9 - Overweight");
            }
            else
            {
                Console.WriteLine("BMI >= 30 - Obese");
            }

            Console.ReadLine();
        }
    }
}

