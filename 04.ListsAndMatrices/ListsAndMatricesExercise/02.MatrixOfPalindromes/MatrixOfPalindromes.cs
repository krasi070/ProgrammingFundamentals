namespace _02.MatrixOfPalindromes
{
    using System;
    using System.Linq;

    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            for (char i = 'a'; i < rows + 'a'; i++)
            {
                for (char j = i; j < cols + i; j++)
                {
                    string currElement = i.ToString() + j.ToString() + i.ToString();
                    Console.Write(currElement + " ");
                }

                Console.WriteLine();
            }
        }
    }
}