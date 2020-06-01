﻿using System;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division for 0 is not allowed! " + e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Only int numbers are allowed! ");
            }
        }
    }
}
