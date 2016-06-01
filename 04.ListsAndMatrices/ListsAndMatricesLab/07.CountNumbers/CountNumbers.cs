namespace _07.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            List<long> numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .OrderBy(n => n)
                .ToList();

            Dictionary<long, int> quantityOfNumbers = new Dictionary<long, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!quantityOfNumbers.ContainsKey(numbers[i]))
                {
                    quantityOfNumbers.Add(numbers[i], 0);
                }

                quantityOfNumbers[numbers[i]]++;
            }

            foreach (var pair in quantityOfNumbers)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}