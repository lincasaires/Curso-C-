﻿using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Lincas", 100.0, 500.0);
            Console.WriteLine(account.Balance);
            
            //account.Balance = 200;
        }
    }
}
