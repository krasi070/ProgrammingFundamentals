namespace _06.RoundingNumbers
{
    using System;
    using System.Linq;

    public class RoundingNumbers
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0} => {1}", arr[i], Math.Round(arr[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}