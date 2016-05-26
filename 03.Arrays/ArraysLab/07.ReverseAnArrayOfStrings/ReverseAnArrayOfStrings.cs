namespace _07.ReverseAnArrayOfStrings
{
    using System;
    using System.Linq;

    public class ReverseAnArrayOfStrings
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                string temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}