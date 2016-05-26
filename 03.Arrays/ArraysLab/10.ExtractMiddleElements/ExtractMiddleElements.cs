namespace _10.ExtractMiddleElements
{
    using System;
    using System.Linq;

    public class ExtractMiddleElements
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine("{{ {0} }}", arr[0]);
            }
            else if (arr.Length % 2 == 0)
            {
                Console.WriteLine("{{ {0}, {1} }}", arr[arr.Length/2 - 1], arr[arr.Length/2]);
            }
            else
            {
                Console.WriteLine("{{ {0}, {1}, {2} }}", arr[arr.Length/2 - 1], arr[arr.Length/2], arr[arr.Length/2 + 1]);
            }
        }
    }
}