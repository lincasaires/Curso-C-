using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(5);
            A.Add(8);
            A.Add(7);
            A.Add(6);

            B.Add(1);
            B.Add(8);
            B.Add(5);
            B.Add(4);

            B.Remove(4);


            A.ExceptWith(B); // Diferença entre conjuntos. A - B
            foreach (int obj in A)
                Console.WriteLine(obj);
            Console.WriteLine();
            A.UnionWith(B); // A união B.   A U B
            foreach (int obj in A)
                Console.WriteLine(obj);
            Console.WriteLine();
            A.IntersectWith(B); // A interseção B (Números que A e B tem em comum)

            // Conjunto não tem posição[i]
            // Elementos do conjunto não se repetem

            foreach (int obj in A)
                Console.WriteLine(obj);

            Console.WriteLine();

            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            if (A.Contains(n))
                Console.WriteLine("Está contido em A");
            else
                Console.WriteLine("Não está contido em A");
        }
    }
}
