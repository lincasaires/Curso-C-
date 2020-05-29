using System;
using System.Globalization;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine("----------------------------------------");

            d1 = DateTime.Today;
            Console.WriteLine(d1);
            d1 = DateTime.UtcNow;
            Console.WriteLine(d1);
            d1 = DateTime.Parse("2000-08-15 13:05:58");// Formato padrão de banco de dados
            Console.WriteLine(d1);
            d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            d1 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);

            Console.WriteLine("-----------------------------------------");

            d1 = new DateTime(2018, 11, 25);
            Console.WriteLine(d1);
            d1 = new DateTime(2018, 11, 25, 20, 45, 3);
            Console.WriteLine(d1);
            d1 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            Console.WriteLine(d1);
            d1 = new DateTime(2018, 11, 25, 20, 45, 3);
        }
    }
}
