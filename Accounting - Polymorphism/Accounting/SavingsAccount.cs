using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceandPolym
{
    class SavingsAccount : Account
    {



        private const int MONTHLY_WITHDRAWL_LIMIT = 5;
        public decimal InterestRate { get; set; }
        public int WithdrawlsThisMonth { get; set; }




        // set the initial Balance

        public SavingsAccount(decimal initialBalance, int withdrawlsThisMonth) : base(initialBalance)
        {

            WithdrawlsThisMonth = withdrawlsThisMonth;
        }

        public override Transaction Withdrawl(decimal amount)
        {
            //implement the withdrawl transaction logic here
            Transaction thisTransaction = new Transaction();

            thisTransaction.AccountNumber = AccountNumber;
            thisTransaction.Amount = amount;
            thisTransaction.TimeStamp = DateTime.Now;
            thisTransaction.isSuccessful = false;


            //perform withdrawl

            if (amount > Balance)
            {
                thisTransaction.Detail = "Transaction Failed, Insufficient Balance." + Balance;
                Console.WriteLine("Transaction Failed, Insufficient Balance.");
            }
            else if (WithdrawlsThisMonth > MONTHLY_WITHDRAWL_LIMIT)
            {
                thisTransaction.Detail = "Transaction Failed, due to monthly withdrawal limit";
                Console.WriteLine("Transaction Failed, due to monthly withdrawal limit");
            }
            else
            {
                Balance -= amount;
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = "Debit transaction for account number " + AccountNumber + " with the amount of 5 " + amount;
                Console.WriteLine("Debit transaction for account number " + AccountNumber + " with the amount of 5 " + amount);
            }

            return thisTransaction;


        }

        public void ProcessProfit()
        {
            Balance += Balance * InterestRate /100;

        }
    }
}
