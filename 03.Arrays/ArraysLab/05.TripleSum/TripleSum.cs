namespace _05.TripleSum
{
    using System;
    using System.Linq;

    public class TripleSum
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            bool foundTripleSum = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr.Contains(arr[i] + arr[j]))
                    {
                        Console.WriteLine("{0} + {1} == {2}", arr[i], arr[j], arr[i] + arr[j]);
                        foundTripleSum = true;
                    }
                }
            }

            if (!foundTripleSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}