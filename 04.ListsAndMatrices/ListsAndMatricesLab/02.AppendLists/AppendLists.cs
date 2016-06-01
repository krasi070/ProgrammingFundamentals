namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            string[] subLists = Console.ReadLine().Split('|');
            var combinedList = new List<int>();
            for (int i = subLists.Length - 1; i >= 0; i--)
            {
                var currSubList = subLists[i]
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                combinedList.AddRange(currSubList);
            }

            Console.WriteLine(string.Join(" ", combinedList));
        }
    }
}