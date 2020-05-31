using Exercicio_Fixacao2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Fixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, annualIncome, healthExpend));                    
                }
                else if(ch == 'c')
                {
                    Console.Write("Number of Employees: ");
                    int qntEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, annualIncome, qntEmployees));
                }
            }
            Console.WriteLine();

            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0.0;
            foreach(TaxPayer person in list)
            {
                Console.WriteLine(person.Name + ": $ " 
                    + person.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += person.Taxes();
            }
            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " 
                + totalTaxes.ToString("F2",CultureInfo.InvariantCulture) );

        }
    }
}
