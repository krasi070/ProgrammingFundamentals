﻿namespace _01.ReverseString
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            Console.WriteLine(string.Join("", str.Reverse()));
        }
    }
}