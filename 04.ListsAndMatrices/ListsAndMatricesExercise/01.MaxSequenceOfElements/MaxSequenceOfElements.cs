namespace _01.MaxSequenceOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfElements
    {
        public static void Main()
        {
            List<long> numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            int startIndex = 0;
            int length = 0;
            int currLength = 1;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currLength++;
                }
                else
                {
                    if (currLength > length)
                    {
                        startIndex = i - currLength + 1;
                        length = currLength;
                    }

                    currLength = 1;
                }
            }

            if (currLength > length)
            {
                startIndex = numbers.Count - currLength;
                length = currLength;
            }

            Console.WriteLine(string.Join(" ", numbers.GetRange(startIndex, length)));
        }
    }
}