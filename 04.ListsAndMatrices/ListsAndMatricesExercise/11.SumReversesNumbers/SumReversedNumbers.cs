namespace _11.SumReversesNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            double sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += ReverseNumber(numbers[i]);
            }

            Console.WriteLine(sum);
        }

        private static double ReverseNumber(double number)
        {
            string reversedNumberStr = number.ToString();
            double reversedNumber = double.Parse(string.Join("", reversedNumberStr.Reverse()));

            return reversedNumber;
        }
    }
}