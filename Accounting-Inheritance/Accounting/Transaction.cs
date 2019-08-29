using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceandPolym
{
    class Transaction
    {
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }


        public bool isSuccessful { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Detail { get; set; }




    }
}
