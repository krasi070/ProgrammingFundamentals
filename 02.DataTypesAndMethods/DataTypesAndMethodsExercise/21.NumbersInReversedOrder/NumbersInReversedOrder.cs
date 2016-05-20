namespace _21.NumbersInReversedOrder
{
    using System;

    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            PrintReversedString(number);
        }

        private static void PrintReversedString(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i].ToString());
            }

            Console.WriteLine();
        }
    }
}