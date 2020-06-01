using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacao.Entities
{
    sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(Customs Fee: " + CustomsFee + ")");
            return base.PriceTag() + sb.ToString();
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
