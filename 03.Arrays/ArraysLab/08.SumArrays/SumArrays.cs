namespace _08.SumArrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main()
        {
            var arr1 = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            var arr2 = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            for (int i = 0; i < Math.Max(arr1.Length, arr2.Length); i++)
            {
                long sum = arr1[i%arr1.Length] + arr2[i%arr2.Length];
                Console.Write(sum + " ");
            }

            Console.WriteLine();
        }
    }
}