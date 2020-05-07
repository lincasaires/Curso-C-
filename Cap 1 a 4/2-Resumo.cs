using System;

namespace _2_Resumo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4.0;
            // FÓRMULA DE BÁSKARA a = -b [+-] raiz(delta)/2a
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            // OPERADORES DE ATRIBUIÇÃO ( +=  -=  *=  /=  %= )
            double n = 10;
            n %= 3.0;
            Console.WriteLine(n);
            
            int n1 = 10;
            Console.WriteLine($" n1 = {n1}");
            int n2 = n1++;
            Console.WriteLine($"    n2 = n1++ = {n2}  -> Neste caso, n2 recebeu n1(10), e então n1 recebeu +1");
            n1 = 10;
            n2 = ++n1;
            Console.WriteLine($"    n2 = ++n1 = {n2}  -> Neste, n1 recebeu +1 e então n2 recebeu n1(11)");
            
            string s = "ABC";
            s += "DEF";
            


        }
    }
}
