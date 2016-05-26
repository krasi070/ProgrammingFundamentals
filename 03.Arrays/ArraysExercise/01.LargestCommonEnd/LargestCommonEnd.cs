namespace _01.LargestCommonEnd
{
    using System;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var secondLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int start = 0;
            int end = 0;

            for (int i = 0; i < Math.Min(firstLine.Length, secondLine.Length); i++)
            {
                if (firstLine[i] == secondLine[i])
                {
                    start++;
                }
                else
                {
                    break;
                }
            }

            for (int i = firstLine.Length - 1, j = secondLine.Length - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (firstLine[i] == secondLine[j])
                {
                    end++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(start, end));
        }
    }
}