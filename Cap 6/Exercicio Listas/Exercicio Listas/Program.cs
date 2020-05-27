using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista_funcionarios = new List<Funcionario>();

            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista_funcionarios.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario employee = lista_funcionarios.Find(x => x.Id == searchId);
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.increaseSalary(percentage);
            
            Console.WriteLine();
            foreach(Funcionario obj in lista_funcionarios)
            {
                Console.WriteLine(obj);
            }
        
        }
    }
}
