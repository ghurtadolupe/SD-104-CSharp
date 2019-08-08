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
            int nCurrent:
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

                Console.WriteLine("Enter another integer or Q to Quit");
                strEntry = Console.ReadLine();
            }



        }
    }
}
