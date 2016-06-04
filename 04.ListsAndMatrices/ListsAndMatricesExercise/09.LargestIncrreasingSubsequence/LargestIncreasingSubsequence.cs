namespace _09.LargestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestIncreasingSubsequence
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] lengths = new int[numbers.Count];
            int[] previousIndexes = new int[numbers.Count];
            int maxLengthIndex = -1;
            int maxLength = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                lengths[i] = 1;
                previousIndexes[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && lengths[j] + 1 > lengths[i])
                    {
                        lengths[i] = lengths[j] + 1;
                        previousIndexes[i] = j;
                    }
                }

                if (maxLength < lengths[i])
                {
                    maxLength = lengths[i];
                    maxLengthIndex = i;
                }
            }

            List<int> largestIncreasingSubsequence = new List<int>();
            int index = maxLengthIndex;
            while (index != -1)
            {
                largestIncreasingSubsequence.Add(numbers[index]);
                index = previousIndexes[index];
            }

            largestIncreasingSubsequence.Reverse();
            Console.WriteLine(string.Join(" ", largestIncreasingSubsequence));
        }
    }
}