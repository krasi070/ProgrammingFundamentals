namespace _12.BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            List<double> sequence = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            int[] args = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bomb = args[0];
            int distance = args[1];

            while (sequence.Contains(bomb))
            {
                int bombIndex = sequence.IndexOf(bomb);
                int startIndex = Math.Max(0, bombIndex - distance);
                int destroyedElementsCount = Math.Min(
                    Math.Min(distance*2 + 1, sequence.Count - (bombIndex - distance)), sequence.Count);
                sequence.RemoveRange(startIndex, destroyedElementsCount);
            }

            Console.WriteLine(sequence.Sum());
        }
    }
}