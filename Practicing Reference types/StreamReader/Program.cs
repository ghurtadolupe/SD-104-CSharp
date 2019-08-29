using System;
using System.IO;

namespace StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
          
           


            //step 1
            FileStream myFileStream = new FileStream("TestFile1.txt", FileMode.Open, FileAccess.Read);

            //step 2
           // StreamReader myFileReader = new StreamReader(myFileStream);

            System.IO.StreamReader myFileReader2 = new System.IO.StreamReader(myFileStream);

            //step 3
            Console.WriteLine(myFileReader2.ReadLine());
            Console.ReadLine();

        }
    }
}
