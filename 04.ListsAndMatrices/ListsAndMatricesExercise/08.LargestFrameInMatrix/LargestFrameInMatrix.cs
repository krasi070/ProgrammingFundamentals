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
            List<List<int>> possibleFrames = new List<List<int>>();
            for (int i = row; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, col] != element)
                {
                    break;
                }

                possibleFrames.Add(new List<int>());
                for (int j = col; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != element)
                    {
                        break;
                    }

                    possibleFrames[i - row].Add(matrix[i, j]);
                }
            }

            List<int[]> frames = new List<int[]>();
            while (possibleFrames.Count > 0)
            {
                int frameWidth = Math.Min(possibleFrames[0].Count, possibleFrames[possibleFrames.Count - 1].Count);
                while (frameWidth >= 0)
                {
                    bool isFrame = true;
                    for (int i = row; i < row + possibleFrames.Count; i++)
                    {
                        if (matrix[i, col + frameWidth - 1] != element)
                        {
                            isFrame = false;
                        }
                    }

                    if (isFrame)
                    {
                        break;
                    }

                    frameWidth--;
                }

                frames.Add(new int[] { possibleFrames.Count, frameWidth });
                possibleFrames.RemoveAt(possibleFrames.Count - 1);
            }
            

            return frames.OrderByDescending(a => a[0] * a[1]).FirstOrDefault();
        }
    }
}