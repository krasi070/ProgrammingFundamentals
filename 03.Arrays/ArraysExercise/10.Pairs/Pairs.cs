namespace _10.Pairs
{
    using System;
    using System.Linq;

    public class Pairs
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            long difference = long.Parse(Console.ReadLine());

            long numberOfPairs = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == difference)
                    {
                        numberOfPairs++;
                    }
                }
            }

            Console.WriteLine(numberOfPairs);
        }
    }
}