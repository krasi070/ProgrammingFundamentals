namespace _03.DiagonalDifference
{
    using System;

    public class DiagonalDifference
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                string[] currRow = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(currRow[j]);
                }
            }

            int primaryDiagonal = 0;
            for (int i = 0; i < size; i++)
            {
                primaryDiagonal += matrix[i, i];
            }

            int secondaryDiagonal = 0;
            for (int i = size - 1, j = 0; i >= 0; i--, j++)
            {
                secondaryDiagonal += matrix[j, i];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}