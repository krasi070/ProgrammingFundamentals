namespace _06.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            double[] realNumbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .OrderBy(r => r)
                .ToArray();

            Dictionary<double, int> countOfRealNumbers = new Dictionary<double, int>();
            for (int i = 0; i < realNumbers.Length; i++)
            {
                if (!countOfRealNumbers.ContainsKey(realNumbers[i]))
                {
                    countOfRealNumbers.Add(realNumbers[i], 0);
                }

                countOfRealNumbers[realNumbers[i]]++;
            }

            foreach (var realNumber in countOfRealNumbers)
            {
                Console.WriteLine("{0} -> {1}", realNumber.Key, realNumber.Value);
            }
        }
    }
}