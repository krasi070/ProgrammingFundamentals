﻿namespace _07.ExchangeVariableValues
{
    using System;

    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}