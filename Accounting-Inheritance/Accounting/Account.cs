﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceandPolym
{
    class Account
    {
        //inheritance
        //parent class
        //summary

            public string AccountNumber { get; set; }
            public decimal Balance { get; set; }

            // set our account balance, initial balance value using constructor
            public Account(decimal initalBalance)
            {
                Balance = initalBalance;
            }

            public void Deposit(decimal amount)
            {
                Balance += amount;
            }


        
    }
}
