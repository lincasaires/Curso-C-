using System;
using System.Globalization;

namespace ExercicioClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();
            Console.WriteLine("Entre com a altura e largura do retângulo:");
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine(x);
        }
    }
}
