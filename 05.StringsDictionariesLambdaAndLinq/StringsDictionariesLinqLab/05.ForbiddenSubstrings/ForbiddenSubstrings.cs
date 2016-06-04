namespace _05.ForbiddenSubstrings
{
    using System;

    public class ForbiddenSubstrings
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string[] forbiddenWords = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                    text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}