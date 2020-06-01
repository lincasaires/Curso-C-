using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_Fixacao.Entities
{
    sealed class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " (used) $" + Price.ToString("F2", CultureInfo.InvariantCulture) + " ");
            sb.Append("(Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")");
            
            return sb.ToString();
        }
    }
}
