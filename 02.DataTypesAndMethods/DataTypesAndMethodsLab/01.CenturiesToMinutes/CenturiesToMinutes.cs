namespace _01.CenturiesToMinutes
{
    using System;

    public class CenturiesToMinutes
    {
        public static void Main()
        {
            long centuries = long.Parse(Console.ReadLine());
            long years = centuries * 100;
            long days = (long)(years * 365.2422);
            decimal hours = days * 24;
            decimal minutes = hours  * 60;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3:F0} hours = {4:F0} minutes", 
                centuries, years, days, hours, minutes);
        }
    }
}