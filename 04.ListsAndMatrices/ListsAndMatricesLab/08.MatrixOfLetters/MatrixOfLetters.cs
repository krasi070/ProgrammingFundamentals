namespace _08.MatrixOfLetters
{
    using System;
    using System.Collections.Generic;

    public class MatrixOfLetters
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            List<char> alphabet = new List<char>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                alphabet.Add(i);
            }

            int currLetter = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(alphabet[currLetter] + " ");
                    currLetter = (currLetter + 1) % alphabet.Count;
                }

                Console.WriteLine();
            }
        }
    }
}