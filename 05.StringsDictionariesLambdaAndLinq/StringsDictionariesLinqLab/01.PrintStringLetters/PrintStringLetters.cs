namespace _01.PrintStringLetters
{
    using System;

    public class PrintStringLetters
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("str[{0}] -> \'{1}\'", i, str[i]);
            }
        }
    }
}