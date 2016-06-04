namespace _04.ExtractSentencesByKeyword
{
    using System;
    using System.Linq;

    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            var sentences = Console.ReadLine()
                .Split(new[] {'.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .Where(s => s.Split(
                    new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, 
                    StringSplitOptions.RemoveEmptyEntries).Contains(word))
                .ToList();

            Console.WriteLine(string.Join("\n", sentences));
        }
    }
}