using System;
using System.Dynamic;
using System.Reflection.PortableExecutable;

namespace _3_Resumo
{
    class Program
    {
        static void Main(string[] args)
        {
         //Não dá pra converter double para float impliciamente
            double a;
            float b;
    
            a = 5.1;
            b = (float)a;

            //Não dá pra converter int pra double implicitamente
            int c = 5;
            int d = 2;

            double resultado = (double) c / d;

            //Entrada de dados
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //Split
            string[] vet = Console.ReadLine().Split(' '); // vai recortar nos espaços em branco ' '
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine($"{p1} {p2} {p3}");

            
        }
    }
}
