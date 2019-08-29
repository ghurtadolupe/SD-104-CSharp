using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceandPolym
{
    //iherited fromAccount CLass. Child class Checking Account
    //summary

    class CheckingAccount:Account
    {


        public CheckingAccount(decimal initalBalance) : base(initalBalance)

        {


        }
            public Transaction Withdrawl(decimal amount)
            {
                //create transaction object
                Transaction thisTransaction = new Transaction();
                thisTransaction.AccountNumber = AccountNumber;
                thisTransaction.Amount = amount;
                thisTransaction.isSuccessful = false;
                thisTransaction.TimeStamp = DateTime.Now;

                // try to process transaction
                if (amount > Balance)
                {
                    thisTransaction.Detail = "Transaction Falied: Insufficent Funds.";
                    Console.WriteLine("Transaction Falied: Insufficent Funds.");
                }
                else
                {
                    Balance -= amount; // Balance = Balance - amount;
                    thisTransaction.isSuccessful = true;
                    thisTransaction.Detail = String.Format("Account#: {0} was debited{1}", thisTransaction.AccountNumber, thisTransaction.Amount);
                    Console.WriteLine("Succesfully withdraw from " + thisTransaction.AccountNumber + " debited amount of " + thisTransaction.Amount);

                }



                return thisTransaction;


            }

        

    }
}
