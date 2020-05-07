using System;
using System.Globalization;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x;
            x = new Produto();
            

            Console.WriteLine("Dados do Produto:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            x.qnt = int.Parse(Console.ReadLine());
            double total = x.qnt * x.preco;
            Console.WriteLine("Dados do produto: " + x);

            x.AddProduto();
            x.AddProduto();
            x.RemoveProduto();
            x.RemoveProduto();

        }
    }
}
