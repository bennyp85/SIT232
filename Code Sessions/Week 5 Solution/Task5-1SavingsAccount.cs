﻿/*************************************************************
** File: SavingsAccount.cs
** Author/s: Justin Rough
** Description:
**     The SavingsAccount class that inherits from the Account
** class for demonstrating inheritance.
*************************************************************/
using System;

namespace BankAccounts
{
    class SavingsAccount : Account
    {
        private const decimal DEFAULT_BALANCE = 0.00M;

        public SavingsAccount()
            : this(DEFAULT_BALANCE)
        {
        }

        public SavingsAccount(decimal balance)
            : base(balance)
        {
        }

        public void Deposit(decimal amount)
        {
            IncreaseBalance(amount);
        }

        public bool Withdraw(decimal amount)
        {
            bool result = true;

            if (Balance >= amount)
                DecreaseBalance(amount);
            else
                result = false;

            return result;
        }
    }
}
