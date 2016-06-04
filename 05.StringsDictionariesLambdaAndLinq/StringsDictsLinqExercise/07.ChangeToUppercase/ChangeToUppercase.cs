namespace _07.ChangeToUppercase
{
    using System;

    public class ChangeToUppercase
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            while (text.Contains("<upcase>"))
            {
                int start = text.IndexOf("<upcase>");
                int end = text.IndexOf("</upcase>");
                Console.Write(text.Substring(0, start));
                string textToUppercase = text.Substring(start + 8, end - start - 8).ToUpper();
                Console.Write(textToUppercase);
                text = text.Substring(end + 9);
            }

            Console.WriteLine(text);
        }
    }
}