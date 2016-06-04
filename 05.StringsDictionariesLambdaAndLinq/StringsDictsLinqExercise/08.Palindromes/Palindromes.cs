namespace _08.Palindromes
{
    using System;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            var palindromes = Console.ReadLine()
                .Split(new[] {' ', ',', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries)
                .Where(s => s == string.Join("", s.Reverse()))
                .Distinct()
                .OrderBy(p => p)
                .ToList();

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}