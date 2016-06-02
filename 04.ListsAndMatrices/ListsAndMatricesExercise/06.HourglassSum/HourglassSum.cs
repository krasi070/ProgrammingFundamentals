namespace _06.HourglassSum
{
    using System;

    public class HourglassSum
    {
        public static void Main()
        {
            double[,] matrix = new double[6, 6];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] currRow = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = double.Parse(currRow[j]);
                }
            }

            double maxSum = double.MinValue;
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    double currSum = CalculateHourglassSum(matrix, i, j);
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }

        private static double CalculateHourglassSum(double[,] matrix, int row, int col)
        {
            double sum = 0;
            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    sum += matrix[i, j];
                }
            }

            sum -= matrix[row + 1, col];
            sum -= matrix[row + 1, col + 2];

            return sum;
        }
    }
}