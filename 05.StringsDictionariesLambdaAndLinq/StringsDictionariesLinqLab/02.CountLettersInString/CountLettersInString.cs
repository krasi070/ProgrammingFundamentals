namespace _02.CountLettersInString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountLettersInString
    {
        public static void Main()
        {
            string str = Console.ReadLine().ToLower();
            Dictionary<char, int> countOfLetters = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!countOfLetters.ContainsKey(str[i]))
                {
                    countOfLetters.Add(str[i], 0);
                }

                countOfLetters[str[i]]++;
            }

            countOfLetters = countOfLetters.OrderBy(c => c.Key).ToDictionary(k => k.Key, v => v.Value);
            foreach (var letter in countOfLetters)
            {
                Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
            }
        }
    }
}