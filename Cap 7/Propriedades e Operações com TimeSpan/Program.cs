using System;
using System.Xml;

namespace Propriedades_e_Operações_com_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {

            // --------------------------------------- //
            /*
            Console.WriteLine("TimeSpan.MaxValue: " + TimeSpan.MaxValue);
            Console.WriteLine("TimeSpan.MinValue: " + TimeSpan.MinValue);
            Console.WriteLine("TimeSpan.Zero: " + TimeSpan.Zero);
            */

            // ------------------PROPRIEDADES--------------------- //
            TimeSpan t = new TimeSpan(10, 20, 10, 30);
            Console.WriteLine("t: " + t);
            /*
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes); 
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds); 
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            */




            // ------------------ OPERAÇÕES --------------------- //
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan sum = t1.Add(t);
            TimeSpan dif = t1.Subtract(t);
            TimeSpan mult = t1.Multiply(2.0);
            TimeSpan div = t1.Divide(2.0);
            Console.WriteLine("t1: " + t1);          
            Console.WriteLine("t1.Add(t): " + sum);
            Console.WriteLine("t1.Subtract(t) : " + dif);
            Console.WriteLine("t1.Multiply(2.0)" + mult);
            Console.WriteLine("t1.Divide(2.0)" + div);
        }

    }
}
    
