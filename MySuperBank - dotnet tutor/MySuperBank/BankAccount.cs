﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount
    {
        //PROPERTIES
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance { 
            get 
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance = balance + item.Amount;
                }
                return balance;
            } 
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        //CONSTRUCTORS
        //a bank at least know the user name and their balance
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;      // assigning to the properties

            // The initial balance rather should be itself a deposit
            MakeDeposit(initialBalance,DateTime.Now, "Initial Balance");

            // everytime adding a new bank account, the number will be add by 1. So each peson will not get a same bank account number  
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        //METHODS
        public void MakeDeposit (decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal (decimal amount, DateTime date, string note)
        {
            if (amount <= 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance <= 0)
            {
                throw new ArgumentOutOfRangeException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}
