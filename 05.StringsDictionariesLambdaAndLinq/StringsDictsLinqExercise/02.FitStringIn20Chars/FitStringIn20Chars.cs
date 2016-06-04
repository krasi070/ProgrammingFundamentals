namespace _02.FitStringIn20Chars
{
    using System;
    using System.Linq;

    public class FitStringIn20Chars
    {
        public static void Main()
        {
            string text = Console.ReadLine().PadRight(20, '*');
            Console.WriteLine(string.Join("", text.Take(20)));
        }
    }
}