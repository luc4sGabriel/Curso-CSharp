using System;
using ExerciseException.Exceptions;

namespace ExerciseException.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                throw new DomainException("You don't have enough balance for this operation");
            }
            if(amount > WithdrawLimit) {
                throw new DomainException("You have exceeded your account withdrawal limit");
            }
            Balance -= amount;
        }
    }
}
