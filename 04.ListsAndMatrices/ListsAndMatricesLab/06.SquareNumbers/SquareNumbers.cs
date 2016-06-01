namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            List<long> numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .Where(n => Math.Sqrt(n) == (int)Math.Sqrt(n))
                .OrderByDescending(n => n)
                .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}