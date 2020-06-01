using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class BusinessAccount : Account //Business account herdando/extendendo tudo que Account tem
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

       
        //Construtor com elementos herdados
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
                Balance += amount;
        }

        //Sobrescrevendo função Withdraw mantendo a base
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); // Balance -= amount + 5
            Balance -= 2;
        }

    }
}
