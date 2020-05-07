using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Classes2
{
    class Produto
    {
        public string nome;
        public double preco;
        public int qnt;

        public string Valortotal()
        {

            double total = qnt * preco;

            return total.ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AddProduto()
        {
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            qnt += int.Parse(Console.ReadLine());
            Console.WriteLine("Dados atualizados: " + ToString());

        }
        public void RemoveProduto()
        {
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qnt -= int.Parse(Console.ReadLine());
            Console.WriteLine("Dados atualizados: " + ToString());
        }

        public override string ToString()
        {
            double soma = qnt * preco;
            return nome + ", $ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + qnt
                + " unidades, Total: $ " + soma.ToString("F2", CultureInfo.InvariantCulture)
                + "\r\n";
        }
    }
}
