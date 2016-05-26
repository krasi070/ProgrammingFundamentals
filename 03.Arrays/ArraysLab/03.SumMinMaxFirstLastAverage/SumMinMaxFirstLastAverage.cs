namespace _03.SumMinMaxFirstLastAverage
{
    using System;
    using System.Linq;

    public class SumMinMaxFirstLastAverage
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(
                "Sum = {0}\nMin = {1}\nMax = {2}\nFirst = {3}\nLast = {4}\nAverage = {5}",
                arr.Sum(),
                arr.Min(),
                arr.Max(),
                arr[0],
                arr[arr.Length - 1],
                arr.Average());
        }
    }
}