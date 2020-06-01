using System;

namespace Var
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 3;

            switch(x)
            {
                case 1: Console.WriteLine("1");
                    break;
                case 2: Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("nem 1 nem 2");
                    break;
            }
        }
    }
}
