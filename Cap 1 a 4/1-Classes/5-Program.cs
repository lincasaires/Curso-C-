using System;
using System.Globalization;

namespace ExercicioClasse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\r\nFuncionário: " + x);
            Console.WriteLine("\r\nDigite a porcentagem par aumentar o salário: ");
            x.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("\r\nDados atualizados: " + x);
        }
    }
}
