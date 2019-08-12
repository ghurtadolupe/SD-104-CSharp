using System;

namespace Consoleapp_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] DaysOfTheWeek = { "SAT", "SUN", "MON", "TUES", "WED", "THURS", "FRI" };
            //The Length measures how many objects are inside the string
            Console.WriteLine(DaysOfTheWeek. Length. ToString());
    
            
    /*
           foreach (string day in DaysOfTheWeek)
            {
                Console.WriteLine("The day is : " + day);
            }

    */
            //the top "foreach" loop is the same as this "for" loop 
           
            //First Declaring the variables (int i = 0;)
            //While "i" is < DaysOfTheWeek's Length, execute this
            //"i++" is saying continue adding one to "i"
           for (int i = 0; i < DaysOfTheWeek.Length; i++)
            {
                Console.WriteLine("The day is : " + DaysOfTheWeek[i]);
            }


            Console.ReadLine();




        }
    }
}
