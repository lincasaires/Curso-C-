using System;
using System.Globalization;

namespace Exercicio_Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //              EXERCÍCIOS DE ESTRUTURA SEQUENCIAL
            /*     Questão 1:

            Console.WriteLine("Informe 2 números inteiros:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine($"{n1}+{n2} = {soma}");         
            */
            /*     Questão 2: 

            Console.WriteLine("Informe o raio do círculo:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159F * Math.Pow(2 , raio);
            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
            */
            /*     Questão 3: 

            Console.WriteLine("Informe 4 valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int diferenca = a * b - c * d;
            Console.WriteLine("DIFERENÇA =" + diferenca); 
            */
            /*    Questão 4: 

            Console.WriteLine("Número do Funcionário:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabalhadas:");
            int hrs = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora:");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = valorHora * hrs;

            Console.WriteLine("\r\nNUMBER = " + num + "\r\nSALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            */
            /*     Questão 5: 

            Console.WriteLine("Peça1- Informe o código, quantidade e valor:");
            string[] vet = Console.ReadLine().Split(' ');
            int codP1 = int.Parse(vet[0]);
            int qntP1 = int.Parse(vet[1]);
            double valP1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Peça1- Informe o código, quantidade e valor:");
            string[] vet2 = Console.ReadLine().Split(' ');
            int codP2 = int.Parse(vet2[0]);
            int qntP2 = int.Parse(vet2[1]);
            double valP2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double pagar = qntP1 * valP1 + qntP2 * valP2;
            Console.WriteLine("VALOR A PAGAR: R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));
            */
            /*     Questão 6*/

            Console.WriteLine("Informe 3 valores (na mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double a = (A * C) / 2;
            double b = Math.PI * Math.Pow(2, C);
            double c = ((A + B) * C) / 2;
            double d = B * B;
            double e = A * B;
            Console.WriteLine("TRIANGULO: {0}\r\nCIRCULO: {1}\r\nTRAPEZIO: {2}\r\nQUADRADO: {3}\r\nRETÂNGULO: {4}",
                                a.ToString("F3", CultureInfo.InvariantCulture),b.ToString("F3", CultureInfo.InvariantCulture), c.ToString("F3", CultureInfo.InvariantCulture), d.ToString("F3", CultureInfo.InvariantCulture), e.ToString("F3", CultureInfo.InvariantCulture));





        }
    }
}
