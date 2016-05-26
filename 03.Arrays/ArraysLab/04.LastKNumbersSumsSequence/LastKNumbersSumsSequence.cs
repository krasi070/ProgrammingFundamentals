namespace _04.LastKNumbersSumsSequence
{
    using System;

    public class LastKNumbersSumsSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] sequence = new long[n];
            sequence[0] = 1;
            for (int i = 1; i < sequence.Length; i++)
            {
                sequence[i] = 0;
                for (int j = Math.Max(0, i - k); j <= i - 1; j++)
                {
                    sequence[i] += sequence[j];
                }   
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}