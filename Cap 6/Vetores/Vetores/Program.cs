using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;

            double[] vect = new double[n]; // Criação do vetor

            for (int i = 0; i < n; i++)
            {
                Console.Write("Posição[" + i + "]: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vect[i];
            }
            Console.WriteLine("AVERAGE HEIGHT = " + (sum/n).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
