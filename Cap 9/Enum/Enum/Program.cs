using Enum_.Entities; // acesso a pasta entities
using Enum_.Entities.Enums;
using System;

namespace Enum_
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment //tipo enumerado
            };

            Console.WriteLine(order);

            // Convertendo tipo enumerado pra string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Convertendo string para tipo enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
