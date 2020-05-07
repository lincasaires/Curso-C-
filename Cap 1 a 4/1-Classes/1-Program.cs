using System;

namespace ClassesMétodosAtributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            x.nome = Console.ReadLine();
            x.idade = int.Parse(Console.ReadLine());

            y.nome = Console.ReadLine();
            y.idade = int.Parse(Console.ReadLine());

            Console.Write("Pessoa mais velha: ");

            if (x.idade > y.idade)
            {
                Console.Write(x.nome);
            }
            else
            {
                Console.WriteLine(y.nome);
            }
        }
    }
}
