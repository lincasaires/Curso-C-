using System;

namespace Time_span
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30); // (HH, mm, ss)
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            t1 = new TimeSpan(900000000L); //9 milhoes de ticks
            Console.WriteLine(t1);
            t1 = new TimeSpan(1, 2, 11, 21); // 1 dia 02:11:21
            Console.WriteLine(t1);
            t1 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine("--------------------------------");

            t1 = TimeSpan.FromDays(1.5); // 1.5 dias
            Console.WriteLine(t1);
        }
    }
}
