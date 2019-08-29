using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppFileReading
{
    class Program
    {
        static void Main(string[] args)
        {

            //step 1
            FileStream myFileStream = new FileStream("TextFile1.txt", FileMode.Open, FileAccess.Read);
            FileStream myFileStream2 = new FileStream("TextFile2.txt", FileMode.Open, FileAccess.Read);

            //step 2
            StreamReader myFileReader = new StreamReader(myFileStream);
            StreamReader myFileReader2 = new StreamReader(myFileStream2);



            //step 3
            Console.WriteLine(myFileReader.ReadLine());
            Console.WriteLine(myFileReader2.ReadLine());


            try
            {
                myFileReader = "Works" + myFileReader;
                myFileStream = new FileStream(myFileStream, FileMode.Create, FileAccess.Write);
                textOut = new StreamWriter(myFileStream);
                for (int i = 0; i < screenText.Length; i++)
                {
                    textOut.WriteLine(screenText[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textOut != null)
                    textOut.Close();
            }










            Console.ReadLine();
        }
    }
}
