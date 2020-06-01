using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacao2.Entities
{
    //Sealed: Não pode ser herdado. Ganho de desempenho
    sealed class Company : TaxPayer //Herdando TaxPayer
    {
        public int QntEmployees { get; set; }

        public Company() { }

        public Company(string name, double annualIncome,int qntEmployees)
            :base(name,annualIncome)
        {
            QntEmployees = qntEmployees;
        }

        public override double Taxes() //Polimorfismo: Sobrescrevendo funçao Taxes de TaxPayer
        {
            double tax = 0.0;
            if (QntEmployees <= 10)
                tax += AnnualIncome * 16 / 100;
            else
                tax += AnnualIncome * 14 / 100;


            return tax;
        }
    }
}
