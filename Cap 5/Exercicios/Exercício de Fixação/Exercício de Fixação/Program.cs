using System;
using System.Globalization;

namespace Exercício_de_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta(0000, "null",0.00);
            Console.Write("Entre com o número da conta: ");
            c.ContaNum = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            c.Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string opcao = Console.ReadLine();
            if (opcao == "s")
            {
                Console.Write("Entre o valor de depósito inicial: $ ");
                c.Saldo += double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: $ ");
            c.Saldo = c.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: $ ");
            c.Saldo =  c.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
        }
    }
}
