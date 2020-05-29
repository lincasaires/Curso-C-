using System;
using System.Globalization;

namespace Vetor_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Product[] vet = new Product[n];
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o nome e o preço do produto[" + i + "]: ");
                string name = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Product { Nome = name, Price = preco };
                sum += vet[i].Price;
            }
            Console.WriteLine();
            Console.WriteLine("AVERAGE PRICE = " + (sum/n).ToString(CultureInfo.InvariantCulture));
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Produto[" + i + "] = " + vet[i].Nome + " R$ " + vet[i].Price);
                Console.WriteLine();
            }
        }
    }
}
