using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            char unicode = '\u0043';
            byte n1 = 255;
            byte max = byte.MaxValue;
            byte min = byte.MinValue;
            int n2 = 2147483647;
            long n3 = 2147483648L;
            float n4 = 4.5478F;
            string texto = "Lucas Aires";
            object obj1 = "Qualquer tipo";
            object obj2 = 6.8368F;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(unicode);
            Console.WriteLine(n1);
            Console.WriteLine("Um Byte tem valor máximo = {0}",max);
            Console.WriteLine($"Um Byte tem valor mínimo = {min}");
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine("Float " + n4.ToString("F2", CultureInfo.InvariantCulture)); /*ToString: Formata pra string;  F2: Casas decimais;  Culture...: troca "," por "."*/
            Console.WriteLine("Meu nome é: " + texto);
            Console.WriteLine(obj1);
            Console.WriteLine($"{obj2} arredondado para 2 casas decimais = {obj2:F2}");
        }
    }
}
