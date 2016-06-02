namespace _07.MatrixGenerator
{
    using System;
    using System.Collections.Generic;

    public class MatrixGenerator
    {
        public static void Main()
        {
            string[] args = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string type = args[0];
            int rows = int.Parse(args[1]);
            int cols = int.Parse(args[2]);
            int[,] matrix = new int[rows, cols];

            switch (type)
            {
                case "A":
                    matrix = BuildATypeMatrix(rows, cols);
                    break;
                case "B":
                    matrix = BuildBTypeMatrix(rows, cols);
                    break;
                case "C":
                    matrix = BuildCTypeMatrix(rows, cols);
                    break;
                case "D":
                    matrix = BuildDTypeMatrix(rows, cols);
                    break;
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static int[,] BuildATypeMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int counter = 1;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[j, i] = counter;
                    counter++;
                }
            }

            return matrix;
        }

        private static int[,] BuildBTypeMatrix(int rows, int cols)
        {
            int counter = 1;
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < cols; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        matrix[j, i] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int j = rows - 1; j >= 0; j--)
                    {
                        matrix[j, i] = counter;
                        counter++;
                    }
                }
            }

            return matrix;
        }

        private static int[,] BuildCTypeMatrix(int rows, int cols)
        {
            int counter = 1;
            int[,] matrix = new int[rows, cols];
            Queue<int[]> cells = new Queue<int[]>();
            cells.Enqueue(new int[] { rows - 1, 0 });
            while (cells.Count > 0)
            {
                int[] currCell = cells.Dequeue();
                if (matrix[currCell[0], currCell[1]] != 0)
                {
                    continue;
                }

                matrix[currCell[0], currCell[1]] = counter;
                counter++;

                if (currCell[0] - 1 >= 0)
                {
                    cells.Enqueue(new int[] { currCell[0] - 1, currCell[1] });
                }

                if (currCell[1] + 1 < cols)
                {
                    cells.Enqueue(new int[] { currCell[0], currCell[1] + 1});
                }
            }

            return matrix;
        }

        private static int[,] BuildDTypeMatrix(int rows, int cols)
        {
            int counter = 1;
            int[,] matrix = new int[rows, cols];
            string type = "down";
            int currRow = 0;
            int currCol = 0;
            matrix[0, 0] = counter;
            counter++;
            while (counter <= rows * cols)
            {
                switch (type)
                {
                    case "down":
                        if (currRow + 1 < rows && matrix[currRow + 1, currCol] == 0)
                        {
                            currRow++;
                        }
                        else
                        {
                            type = "right";
                            continue;
                        }

                        break;
                    case "up":
                        if (currRow - 1 >= 0 && matrix[currRow - 1, currCol] == 0)
                        {
                            currRow--;
                        }
                        else
                        {
                            type = "left";
                            continue;
                        }

                        break;
                    case "right":
                        if (currCol + 1 < cols && matrix[currRow, currCol + 1] == 0)
                        {
                            currCol++;
                        }
                        else
                        {
                            type = "up";
                            continue;
                        }

                        break;
                    case "left":
                        if (currCol - 1 >= 0 && matrix[currRow, currCol - 1] == 0)
                        {
                            currCol--;
                        }
                        else
                        {
                            type = "down";
                            continue;
                        }

                        break;
                }

                matrix[currRow, currCol] = counter;
                counter++;
            }

            return matrix;
        }
    }
}