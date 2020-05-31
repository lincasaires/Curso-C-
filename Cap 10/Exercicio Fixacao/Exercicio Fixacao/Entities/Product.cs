using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_Fixacao.Entities
{
    class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " $" + Price.ToString("F2", CultureInfo.InvariantCulture) + " ");
            return sb.ToString();
        }
    }
}
