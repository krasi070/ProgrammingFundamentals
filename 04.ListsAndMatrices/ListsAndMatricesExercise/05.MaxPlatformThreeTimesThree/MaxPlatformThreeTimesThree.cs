namespace _05.MaxPlatformThreeTimesThree
{
    using System;
    using System.Linq;

    public class MaxPlatformThreeTimesThree
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            double[,] matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] currRow = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = double.Parse(currRow[j]);
                }
            }

            double maxSum = double.MinValue;
            int startRow = 0;
            int startCol = 0;
            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    double currSum = CalculatePlatformSum(matrix, i, j);
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        startRow = i;
                        startCol = j;
                    }
                }
            }

            Console.WriteLine(maxSum);
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static double CalculatePlatformSum(double[,] matrix, int row, int col)
        {
            double sum = 0;
            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }
    }
}