namespace _07.MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            int maxLength = 0;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currLength = 1;
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        currLength++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currLength > maxLength)
                {
                    maxLength = currLength;
                    index = i;
                }
            }

            for (int i = index; i < index + maxLength; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}