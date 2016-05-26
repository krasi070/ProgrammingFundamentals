namespace _03.FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            long[] firstFold = new long[arr.Length/4];
            long[] secondFold = new long[arr.Length/4];
            long[] middlePart = new long[arr.Length/2];
            long[] sum = new long[arr.Length/2];
            for (int i = firstFold.Length - 1, j = 0; i >= 0; i--, j++)
            {
                firstFold[j] = arr[i];
            }

            for (int i = arr.Length - 1, j = 0; i >= arr.Length/4*3; i--, j++)
            {
                secondFold[j] = arr[i];
            }

            for (int i = arr.Length/4, j = 0; i < arr.Length/4*3; i++, j++)
            {
                middlePart[j] = arr[i];
            }

            for (int i = 0; i < middlePart.Length; i++)
            {
                if (i < middlePart.Length/2)
                {
                    sum[i] += middlePart[i] + firstFold[i];
                }
                else
                {
                    sum[i] += middlePart[i] + secondFold[i - middlePart.Length/2];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}