using System;

namespace InheritanceandPolym
{
   class Program
    {

        static void Main(string[] args)
        {
            Account myAccount;
            myAccount = new CheckingAccount(1000);
            Console.WriteLine(myAccount.GetType());

            myAccount = new SavingsAccount(2000, 0);
            myAccount.Withdrawl(1500);
            myAccount.Deposit(500);


            SavingsAccount mySav = new SavingsAccount(1000, 2);
            mySav.InterestRate = 10;
            mySav.ProcessProfit();
            Console.WriteLine("Balance after processing profit " + mySav.Balance);









            Console.WriteLine(myAccount.Balance);


            Console.WriteLine(myAccount.GetType());






            Console.ReadLine();
        }
    }

    
}
