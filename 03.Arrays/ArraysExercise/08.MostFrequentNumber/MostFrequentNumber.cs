namespace _08.MostFrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            var knownNumbers = new List<long>();
            long maxCount = 0;
            long number = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (!knownNumbers.Contains(arr[i]))
                {
                    long currCount = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            currCount++;
                        }
                    }

                    knownNumbers.Add(arr[i]);
                    if (currCount > maxCount)
                    {
                        maxCount = currCount;
                        number = arr[i];
                    }
                }
            }

            Console.WriteLine(number);
        }
    }
}