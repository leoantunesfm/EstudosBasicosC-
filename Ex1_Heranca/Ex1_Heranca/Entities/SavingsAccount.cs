using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance(double amount)
        {
            Balance += Balance * (InterestRate / 100.0);
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
