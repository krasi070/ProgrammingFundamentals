namespace _02.RandomizeWords
{
    using System;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Random random = new Random();
            while (words.Count > 0)
            {
                string word = words[random.Next(0, words.Count)];
                words.Remove(word);
                Console.WriteLine(word);
            }
        }
    }
}