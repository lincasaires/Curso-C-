using Exercicio_de_Fixacao.Entities;
using Exercicio_de_Fixacao.Entities.Enums;
using System;
using System.Globalization;

namespace Exercicio_de_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client1 = new Client(clientName, email, birthDate);
            Console.WriteLine("Enter order data: ");
            Console.Write("Status (Pending_Payment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order1 = new Order(DateTime.Now, status, client1);
            
            Console.WriteLine("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int prodQnt = int.Parse(Console.ReadLine());
                Product product = new Product(prodName, prodPrice);
                OrderItem item = new OrderItem(prodQnt, product);
                order1.AddItem(item);
            }
            Console.WriteLine();
            Console.WriteLine(order1);
        }
    }
}
