using System;

namespace Tipo_Referencia_Tipo_Valor_and_Nullable
{
    class Program //Classes são tipo referência
    {
        static void Main(string[] args)
        {
            double? x = null;  // Double é um tipo valor (struct) que por não recebe null por padrão, o "?" torna ele Nullable
            double y = x ?? 0.0; // Double y não é Nullable. Se o valor de x for null, y = 0.0. Senão: y = x

            Console.WriteLine(x.GetValueOrDefault()); // Pega o valor de x ou, caso seja null, pega o default de double "0"
            Console.WriteLine(x.HasValue); // Retorna true se a variável tiver valor e false caso seja null
            
            if (x.HasValue)
                Console.WriteLine(x.Value); // Vai dar erro caso a variável seja null, caso contrário retorna o valor
            else
                Console.WriteLine("X is null");

            Console.WriteLine(y);

        }
    }
}
