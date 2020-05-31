using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacao2.Entities
{
    //Sealed: esta classe agora não pode ser herdada. Ganho de desempenho.
    sealed class Individual : TaxPayer //Herança: métodos e atributos de TaxPayer herdado
    {
        public double HealthExpend { get; set; }

        public Individual() { }
        public Individual(string name, double annualIncome, double healthExpend)
            : base(name, annualIncome)
        {
            HealthExpend = healthExpend;
        }

        public override double Taxes() //Polimorfismo: utilizando metodo abstrato Taxes() de TaxPayer
        {
            double tax = 0.0;
            if (AnnualIncome < 20000)
            {
                tax += AnnualIncome * 15 / 100;
            }
            else
                tax += AnnualIncome * 25 / 100;

            if (HealthExpend > 0)
                tax -= HealthExpend * 50 / 100;

            return tax;
        }
    }
}
