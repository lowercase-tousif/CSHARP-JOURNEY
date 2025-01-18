using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringDesignPatterns
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        {
            deposit(balance);
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void SetBalance(decimal balance)
        {
            this.balance += balance;
        }

        public void deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount must be positive and greater than zero.");
            }
            this.balance += amount;
        }

        public void withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive and greater than zero.");
            }

            if (amount > balance)
            {
                throw new ArgumentException("Insufficient balance.");
            }
            this.balance -= amount;
        }
    }
}