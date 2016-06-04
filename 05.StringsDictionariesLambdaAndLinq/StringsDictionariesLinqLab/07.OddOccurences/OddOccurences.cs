namespace _07.OddOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurences
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().ToLower().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> countOfWords = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!countOfWords.ContainsKey(words[i]))
                {
                    countOfWords.Add(words[i], 0);
                }

                countOfWords[words[i]]++;
            }

            List<string> oddOccurences = countOfWords
                .Where(w => w.Value%2 == 1)
                .ToDictionary(k => k.Key, v => v.Value)
                .Keys
                .ToList();
            Console.WriteLine(string.Join(", ", oddOccurences));
        }
    }
}