﻿namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(new[] {' ', '\t', '\n', ':', ',', ';', '.', '!', '?', '(', ')', '"', '\'', '\\', '/', '[', ']'},
                    StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();            
            List<string> mixedCase = new List<string>();            
            List<string> upperCase = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                bool containsOnlyLowerCase = ContainsOnlyLowerCase(words[i]);
                bool containsOnlyUpperCase = ContainsOnlyUpperCase(words[i]);
                if (containsOnlyLowerCase)
                {
                    lowerCase.Add(words[i]);
                }
                else if (containsOnlyUpperCase)
                {
                    upperCase.Add(words[i]);
                }
                else
                {
                    mixedCase.Add(words[i]);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }

        private static bool ContainsOnlyLowerCase(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!(str[i] >= 'a' & str[i] <= 'z'))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool ContainsOnlyUpperCase(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!(str[i] >= 'A' & str[i] <= 'Z'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}