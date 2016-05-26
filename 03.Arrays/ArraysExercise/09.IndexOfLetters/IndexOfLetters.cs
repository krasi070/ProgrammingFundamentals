namespace _09.IndexOfLetters
{
    using System;

    public class IndexOfLetters
    {
        public static void Main()
        {
            char[] letters =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 
                'n',  'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (word[i] == letters[j])
                    {
                        Console.WriteLine("{0} -> {1}", word[i].ToString(), j);
                    }
                }
            }
        }
    }
}