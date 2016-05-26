namespace _11.EqualSums
{
    using System;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                long leftSum = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += arr[j];
                }

                long rightSum = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}