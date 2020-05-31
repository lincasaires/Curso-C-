using System;
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
         //SOBREPOSIÇÃO- virtual: Agora as subclasses podem ter sua própria versão desta função utilizando override (Veja em SavingsAccount e BusinessAccount)
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.00;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
