using System;

namespace InheritanceandPolym
{
   class Program
    {

        static void Main(string[] args)
        {
            CheckingAccount myChkAccount = new CheckingAccount(1000);
            Console.WriteLine("Initiate withdrawl of $250");
            myChkAccount.Withdrawl(250);
            Console.WriteLine("balance is : $" + myChkAccount.Balance);

            Console.ReadLine();
            Console.WriteLine("Initiate withdrawl of $850");
            myChkAccount.Withdrawl(850);
            Console.WriteLine("Balance is: $" + myChkAccount.Balance);

            Console.ReadLine();
        }
    }

    
}
