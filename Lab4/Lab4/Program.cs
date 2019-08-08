using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int nLargest;
            int nSmallest;
            int nCurrent;
            string strEntry;

            //first integer
            Console.WriteLine("Enter an integer ");
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another integer or Q to Quit");
            strEntry = Console.ReadLine();

            //loop
            while(strEntry != "Q" )
            {
                nCurrent = Convert.ToInt32(strEntry);

                //check to see if input should replace largest or smallest
                if(nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }
                
                else if(nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                }

                Console.WriteLine("Enter another integer or Q to Quit");
                strEntry = Console.ReadLine();
            }

            Console.WriteLine("The largest value you entered was " + nLargest + ".");
            Console.WriteLine("The smallest you entered was " + nSmallest + ".");

            Console.ReadLine();



        }
    }
}
