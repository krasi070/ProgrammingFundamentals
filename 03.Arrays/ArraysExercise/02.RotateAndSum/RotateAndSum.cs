namespace _02.RotateAndSum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            var sum = new long[arr.Length];
            int timesToRotate = int.Parse(Console.ReadLine());

            for (int i = 0; i < timesToRotate; i++)
            {
                arr = Rotate(arr);
                for (int j = 0; j < arr.Length; j++)
                {
                    sum[j] += arr[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        private static long[] Rotate(long[] arr)
        {
            var rotated = new long[arr.Length];
            rotated[0] = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                rotated[i + 1] = arr[i];
            }

            return rotated;
        }
    }
}