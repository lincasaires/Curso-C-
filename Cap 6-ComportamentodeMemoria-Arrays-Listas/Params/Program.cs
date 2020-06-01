using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)  // Params, declarado na classe, serve para trabalhar com uma quantidade variável de parametros
        {
            double soma = Calculator.Sum(1, 2, 3);
            Console.WriteLine(soma);
        }
    }
}
