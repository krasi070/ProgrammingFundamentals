namespace _06.StringsAndObjects
{
    using System;

    public class StringsAndObjects
    {
        public static void Main()
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();
            object combined = firstStr + " " + secondStr;
            string combinedStr = (string) combined;
            Console.WriteLine(combinedStr);
        }
    }
}