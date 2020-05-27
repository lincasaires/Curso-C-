using System;
using System.Globalization;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat;
            double[] diag;
            int negativo = 0;

            Console.WriteLine("Matriz de ordem: ");
            int n = int.Parse(Console.ReadLine());

            mat = new double[n, n];
            diag = new double[n];

            Console.WriteLine();
            Console.WriteLine(".Lenght: " + mat.Length); //Quantidade de Elementos
            Console.WriteLine(".GetLenght(1): " + mat.GetLength(1)); // Quantidade da segunda dimensão da matriz
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Insira um valor em [" + i + ", " + j + "]");
                    mat[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (i == j)
                    {
                        diag[i] = mat[i, j];
                        
                    }

                    if (mat[i,j] < 0)
                    {
                        negativo += 1;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Diagonal principal: " );
            foreach(double obj in diag)
            {
                Console.Write(obj + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Quantidade de numeros negativos: " + negativo);
            

        }
    }
}
