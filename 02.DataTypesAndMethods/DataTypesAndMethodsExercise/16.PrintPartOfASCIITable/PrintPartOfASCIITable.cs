namespace _16.PrintPartOfASCIITable
{
    using System;

    public class PrintPartOfASCIITable
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (char i = (char)start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}