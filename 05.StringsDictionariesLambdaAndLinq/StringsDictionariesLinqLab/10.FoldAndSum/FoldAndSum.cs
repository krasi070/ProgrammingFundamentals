namespace _10.FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var firstPart = numbers.Take(numbers.Length/4).Reverse().ToArray();
            var middlePart = numbers.Skip(numbers.Length/4).Take(numbers.Length/2).ToArray();
            var lastPart = numbers.Skip(numbers.Length/2 + numbers.Length/4).Reverse().ToArray();
            for (int i = 0; i < firstPart.Length; i++)
            {
                middlePart[i] += firstPart[i];
            }

            for (int i = 0; i < lastPart.Length; i++)
            {
                middlePart[middlePart.Length/2 + i] += lastPart[i];
            }

            Console.WriteLine(string.Join(" ", middlePart));
        }
    }
}