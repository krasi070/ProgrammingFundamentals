namespace _06.ReverseWordsInASentence
{
    using System;
    using System.Linq;

    public class ReverseWordsInASentence
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            char[] seperators = new char[]
            {
                ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?'
            };

            char[] otherSeperators = new char[256 - seperators.Length];
            int index = 0;
            for (char i = (char)0; i < 255; i++)
            {
                if (!seperators.Contains(i))
                {
                    otherSeperators[index] = i;
                    index++;
                }
            }

            var words = text
                .Split(seperators, StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();
            var nonWords = text
                .Split(otherSeperators, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int i = 0; i < words.Count; i++)
            {
                Console.Write(words[i] + nonWords[i]);
            }

            Console.WriteLine();
        }
    }
}