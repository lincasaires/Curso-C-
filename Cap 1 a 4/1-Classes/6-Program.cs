using System;
using System.Globalization;

namespace ExercicioClasse3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            Console.Write("Nome do aluno: ");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            x.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(x);

        }
    }
}
