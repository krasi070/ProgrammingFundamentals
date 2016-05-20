namespace _10.FilledSquare
{
    using System;

    public class FilledSquare
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            DrawFilledSquare(size);
        }

        private static void DrawFilledSquare(int size)
        {
            Console.WriteLine(new string('-', size * 2));

            for (int i = 0; i < size - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < (size * 2 - 2) / 2; j++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine("-");
            }

            Console.WriteLine(new string('-', size * 2));
        }
    }
}