﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get;private set; }
        public double Balance { get; protected set; } // Alterável apenas em subclasses


        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount + 5.00;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
