namespace _09.ShortWordsSorted
{
    using System;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var shortWords = Console.ReadLine().ToLower()
                .Split(
                    new[] {' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?'},
                    StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(s => s.Length < 5)
                .OrderBy(s => s)
                .ToList();

            Console.WriteLine(string.Join(", ", shortWords));
        }
    }
}