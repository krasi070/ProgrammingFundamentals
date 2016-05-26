namespace _02.ReverseAnArrayOfIntegers
{
    using System;

    public class ReverseAnArrayOfIntegers
    {
        public static void Main()
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int[] arr = new int[numberOfNumbers];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}