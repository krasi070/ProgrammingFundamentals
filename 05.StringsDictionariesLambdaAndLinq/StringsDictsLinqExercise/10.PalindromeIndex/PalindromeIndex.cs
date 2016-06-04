namespace _10.PalindromeIndex
{
    using System;
    using System.Linq;

    public class PalindromeIndex
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            if (text == string.Join("", text.Reverse()))
            {
                Console.WriteLine(-1);
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    string possiblePalindrome = text.Substring(0, i) + text.Substring(i + 1);
                    if (possiblePalindrome == string.Join("", possiblePalindrome.Reverse()))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}