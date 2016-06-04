namespace _09.Capitalization
{
    using System;
    using System.Linq;

    public class Capitalization
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new[] {' ', '.', ',', '?', '!', ';'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w = w[0].ToString().ToUpper() + w.Substring(1))
                .ToList();

            Console.WriteLine(string.Join(" ", words));
        }
    }
}