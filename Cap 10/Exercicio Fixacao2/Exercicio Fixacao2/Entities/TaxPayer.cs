using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacao2.Entities
{
   abstract class TaxPayer //Abstract: não pode ser instanciada em outra classe
    {
        public string Name { get; protected set; }
        public double AnnualIncome { get; protected set; }

        public TaxPayer() { }

        public TaxPayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Taxes();
    }
}
