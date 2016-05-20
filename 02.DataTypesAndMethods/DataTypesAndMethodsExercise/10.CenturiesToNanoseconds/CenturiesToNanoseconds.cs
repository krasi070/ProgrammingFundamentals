﻿namespace _10.CenturiesToNanoseconds
{
    using System;

    public class CenturiesToNanoseconds
    {
        public static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            long days = (long) (years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine(
                "{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5:F0} seconds" + 
                " = {6:F0} milliseconds = {7:F0} microseconds = {8:F0} nanoseconds",
                centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}