using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleVS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Card myCard = new Card("Q", "Heart", 13);
            Console.WriteLine(myCard.ToString());
            myCard.Val = 10;
            Console.ReadLine();
            
        }
    }
}
