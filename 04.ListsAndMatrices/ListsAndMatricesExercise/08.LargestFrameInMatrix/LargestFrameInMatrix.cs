namespace _08.LargestFrameInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestFrameInMatrix
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] curRow = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(curRow[j]);
                }
            }

            List<string> frames = new List<string>();
            int maxFrame = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int[] frameDimensions = GetFrameDimensions(matrix, i, j);
                    if (frameDimensions != null)
                    {
                        if (maxFrame < frameDimensions[0] * frameDimensions[1])
                        {
                            maxFrame = frameDimensions[0]*frameDimensions[1];
                            frames.Clear();
                            frames.Add(frameDimensions[0] + "x" + frameDimensions[1]);
                        }
                        else if (maxFrame == frameDimensions[0] * frameDimensions[1])
                        {
                            frames.Add(frameDimensions[0] + "x" + frameDimensions[1]);
                        }
                    }
                }
            }

            frames.Sort();
            Console.WriteLine(string.Join(", ", frames));
        }

        private static int[] GetFrameDimensions(int[,] matrix, int row, int col)
        {
            int element = matrix[row, col];
            int currRow = row;
            int currCol = col;
            int rowsLeft = 0;
            List<int> connections = new List<int>();
            while (currRow < matrix.GetLength(0) && matrix[currRow, currCol] == element)
            {
                currRow++;
                rowsLeft++;
                if (currCol < matrix.GetLength(1) - 1 && matrix[currRow, currCol + 1] == element)
                {
                    connections.Add(currRow);
                }
            }

            connections = connections.OrderByDescending(n => n).ToList();

            int colsUp = 0;
            currRow = row;
            List<int> connections2 = new List<int>();
            while (currCol < matrix.GetLength(1) && matrix[currRow, currCol] == element)
            {
                currCol++;
                colsUp++;
                if (currRow < matrix.GetLength(0) - 1 && matrix[currRow + 1, currCol] == element)
                {
                    connections2.Add(currCol);
                }
            }

            connections2 = connections2.OrderByDescending(n => n).ToList();

            currCol--;
            int rowsRight = 0;
            while (currRow < matrix.GetLength(0) && matrix[currRow, currCol] == element)
            {
                currRow++;
                rowsRight++;
            }

            currRow--;
            int colsDown = 0;
            currCol = col;
            while (currCol < matrix.GetLength(1) && matrix[currRow, currCol] == element)
            {
                currCol++;
                colsDown++;
            }

            if (rowsLeft <= rowsRight && colsUp <= colsDown)
            {
                return new int[] { rowsLeft, colsUp };
            }
            else if (rowsLeft >= rowsRight && colsUp >= colsDown)
            {
                return new int[] { rowsRight, colsDown };
            }
            else if (rowsLeft <= rowsRight && colsUp >= colsDown)
            {
                return new int[] { rowsLeft, colsDown };
            }
            else if (rowsLeft >= rowsRight && colsUp <= colsDown)
            {
                return new int[] { rowsRight, colsUp };
            }

            return null;
        }
    }
}