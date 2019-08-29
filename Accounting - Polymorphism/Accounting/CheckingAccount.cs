using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceandPolym
{
    //iherited from Account Class. Child class Checking Account
    //summary               |       (To declare a class as a child or derived class, simply place a colon (:) after the class name declaration
    //                      V
    class CheckingAccount:Account
    {


        public CheckingAccount(decimal initalBalance) : base(initalBalance)

        {


        }
            public override Transaction Withdrawl(decimal amount)
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
                    thisTransaction.Detail = "Transaction Failed: Insufficent Funds.";
                    Console.WriteLine("Transaction Failed: Insufficent Funds.");
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
