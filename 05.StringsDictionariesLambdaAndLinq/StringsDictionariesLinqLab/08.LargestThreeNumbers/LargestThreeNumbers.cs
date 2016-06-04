namespace _08.LargestThreeNumbers
{
    using System;
    using System.Linq;

    public class LargestThreeNumbers
    {
        public static void Main()
        {
            var largestThreeNumbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", largestThreeNumbers));
        }
    }
}