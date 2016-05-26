namespace _06.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            int maxLength = 0;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currLength = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
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