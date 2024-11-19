using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{

//    2.  Create a Bank class, assign balance in constructor, create deposit & withdraw method & display methods
//Deposit will add amount in balance
//Withdraw will remove the amount from balance.amount should be remove if its less than balance
//Display will show balance

    internal class Bank
    {
        private double balance;
        private int amount;

        public Bank(double bal, int amt) { 
            balance = bal;
            amount = amt;
        }
        public void deposit(int amt) { 
            balance += amt;
        }

        public void withdraw(int amt) {
            if (amt < balance)
            {
                balance -= amt;
            }
            else {
                Console.WriteLine("balance less than withdraw amt");
            }
        }

        public void display() {
            Console.WriteLine(balance);
        }
    }
}
