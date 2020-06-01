using System;

namespace Matriz_Exercicio_Resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            int[] diagonal = new int[n];
            int negative = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe a linha " + i + ": ");
                string[] vet = Console.ReadLine().Split(' ');


                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);

                    if (i == j)
                        diagonal[i] = mat[i, j];

                    if (mat[i, j] < 0)
                        negative += 1;

                }
            }

            Console.WriteLine();
            Console.Write("Main diagonal: ");
            foreach(int obj in diagonal)
                Console.Write(obj + " ");

            Console.WriteLine();
            Console.WriteLine("Negative numbers: " + negative);
        }
    }
}
