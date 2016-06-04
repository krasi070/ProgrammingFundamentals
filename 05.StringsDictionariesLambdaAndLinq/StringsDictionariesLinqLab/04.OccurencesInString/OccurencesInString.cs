namespace _04.OccurencesInString
{
    using System;

    public class OccurencesInString
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string substr = Console.ReadLine().ToLower();

            int countOfOccurences = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string currStr = text.Substring(i);
                if (currStr.StartsWith(substr))
                {
                    countOfOccurences++;
                }
            }

            Console.WriteLine(countOfOccurences);
        }
    }
}