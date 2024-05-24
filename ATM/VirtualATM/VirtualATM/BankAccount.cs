using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualATM
{
    public class BankAccount
    {
        public string CardNumber { get; set; }
        public int AccountBalance { get; set; } 

        public int Pin { get; set; }

        public BankAccount(string cardNum, int accountBalance, int pinNum )
        {
            this.CardNumber = cardNum;
            this.AccountBalance = accountBalance;
            this.Pin = pinNum;
        }
    }

    
    

   
}
