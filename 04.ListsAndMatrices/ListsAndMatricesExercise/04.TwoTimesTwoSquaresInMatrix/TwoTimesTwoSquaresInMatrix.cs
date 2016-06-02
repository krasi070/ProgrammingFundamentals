namespace _04.TwoTimesTwoSquaresInMatrix
{
    using System;
    using System.Linq;

    public class TwoTimesTwoSquaresInMatrix
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] currRow = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = char.Parse(currRow[j]);
                }
            }

            int countSquares = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && 
                        matrix[i, j + 1] == matrix[i + 1, j] &&
                        matrix[i + 1, j] == matrix[i + 1, j + 1])
                    {
                        countSquares++;
                    }
                }
            }

            Console.WriteLine(countSquares);
        }
    }
}