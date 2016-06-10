namespace _03.TargetMultiplier
{
    using System;

    public class TargetMultiplier
    {
        public static void Main()
        {
            string[] dimensions = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            long[,] matrix = new long[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] currRow = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = long.Parse(currRow[j]);
                }
            }

            string[] target = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int targetRow = int.Parse(target[0]);
            int targetCol = int.Parse(target[1]);
            long sum = 0;
            for (int i = targetRow - 1; i < targetRow + 2; i++)
            {
                for (int j = targetCol - 1; j < targetCol + 2; j++)
                {
                    if (!(i == targetRow && j == targetCol))
                    {
                        sum += matrix[i, j];
                        matrix[i, j] *= matrix[targetRow, targetCol];
                    }
                }
            }

            matrix[targetRow, targetCol] *= sum;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}