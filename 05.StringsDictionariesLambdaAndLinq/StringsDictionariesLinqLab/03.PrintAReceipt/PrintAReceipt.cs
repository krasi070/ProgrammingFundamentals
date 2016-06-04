namespace _03.PrintAReceipt
{
    using System;
    using System.Linq;

    public class PrintAReceipt
    {
        public static void Main()
        {
            double[] prices = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Console.WriteLine("/----------------------\\");
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = Math.Round(prices[i], 2);
                string price = string.Format("{0:F2}", prices[i]);
                Console.WriteLine("|{0}{1:F2} |", new string(' ', 21 - price.Length), price);
            }

            double totalPrice = Math.Round(prices.Sum(), 2);
            string totalPriceResult = string.Format("{0:F2}", totalPrice);
            Console.WriteLine("|----------------------|");
            Console.WriteLine("| Total:{0}{1:F2} |", new string(' ', 14 - totalPriceResult.Length), totalPriceResult);
            Console.WriteLine("\\----------------------/");
        }
    }
}