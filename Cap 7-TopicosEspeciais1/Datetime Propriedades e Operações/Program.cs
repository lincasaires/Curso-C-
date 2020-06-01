using System;

namespace Datetime_Propriedades_e_Operações
{
    class Program
    {
        static void Main(string[] args)
        {


            // -------------------PROPRIEDADES--------------------  //
            DateTime d = new DateTime(2001, 8, 15, 13, 48, 50, 275);
            /*
            Console.WriteLine("Propiedades DateTime");
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month); 
            Console.WriteLine("10) Second: " + d.Second); 
            Console.WriteLine("11) Ticks: " + d.Ticks); 
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine();
            */

            // -------------------FORMATAÇÃO--------------------- //

            DateTime d2 = new DateTime(2001, 8, 15, 13, 48, 50, 275);
            /*
            Console.WriteLine("ToLongDateString(): " + d2.ToLongDateString());
            Console.WriteLine("ToShortDateString(): " + d2.ToShortDateString());
            Console.WriteLine("ToLongTimeString(): " + d2.ToLongTimeString());
            Console.WriteLine("ToLongTimeString(): " + d2.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("ToLongTimeString(): " + d2.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            */

            // -------------------OPERAÇÕES--------------------- //
            DateTime d3 = new DateTime(2001, 8, 15, 13, 48, 50, 275);
            d2 = d3.AddDays(20);
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("AddHours(2): " + d3.AddHours(2));
            Console.WriteLine("AddMinutes: " +d3.AddMinutes(10));
            Console.WriteLine("d2.Subtract(d3): " + d2.Subtract(d3));


        }
    }
}
