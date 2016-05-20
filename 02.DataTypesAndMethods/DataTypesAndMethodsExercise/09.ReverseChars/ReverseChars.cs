namespace _09.ReverseChars
{
    using System;

    public class ReverseChars
    {
        public static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            Console.WriteLine(thirdChar.ToString() + secondChar + firstChar);
        }
    }
}