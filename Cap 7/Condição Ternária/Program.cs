using System;

namespace Condição_Ternária
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            //    (condição) ? if true : if false
            string y = (x > 10) ? y = "x > 10" : y = "x <= 10";
            Console.WriteLine(y);

            //    Direto no cw
            Console.WriteLine((x > 10) ? y = "x > 10" : y = "x <= 10");
        }
    }
}
