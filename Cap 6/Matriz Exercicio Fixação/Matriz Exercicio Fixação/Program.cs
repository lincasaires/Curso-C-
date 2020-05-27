using System;

namespace Matriz_Exercicio_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            int n;
            int[,] mat;
            string[] linha;

            Console.Write("Informe a quantidade de linhas M: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de colunas N: ");
            n = int.Parse(Console.ReadLine());
            mat = new int[m, n];
            linha = new string[n];

            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                Console.Write("Informe os " + n + " elementos da linha " + i + ": ");
                linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);

                }
            }

            Console.WriteLine();
            Console.Write("Informe um número inteiro da matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Position [" + i + ", " + j + "]");
                        if (j > 0)
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        if (j < n - 1)
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (i < m - 1)
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        if (i > 0)
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                    }
                }


        }
    }
}
