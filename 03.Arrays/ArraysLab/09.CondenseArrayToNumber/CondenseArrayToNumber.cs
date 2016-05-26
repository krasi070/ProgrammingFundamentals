namespace _09.CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            var arr1 = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            while (arr1.Length > 1)
            {
                var arr2 = new long[arr1.Length - 1];

                for (int j = 0; j < arr1.Length - 1; j++)
                {
                    arr2[j] = arr1[j] + arr1[j + 1];
                }

                arr1 = arr2;
            }

            Console.WriteLine(arr1[0]);
        }
    }
}