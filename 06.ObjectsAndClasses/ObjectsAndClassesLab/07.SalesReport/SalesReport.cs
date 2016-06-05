namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        public static void Main()
        {
            int numberOfSales = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();
            for (int i = 0; i < numberOfSales; i++)
            {
                string[] saleArgs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.None);
                string town = saleArgs[0];
                string product = saleArgs[1];
                double price = double.Parse(saleArgs[2]);
                double quantity = double.Parse(saleArgs[3]);
                Sale currSale = new Sale(town, product, price, quantity);
                sales.Add(currSale);
            }

            sales = sales.OrderBy(s => s.Town).ToList();
            Dictionary<string, double> salesReport = new Dictionary<string, double>();
            for (int i = 0; i < sales.Count; i++)
            {
                if (!salesReport.ContainsKey(sales[i].Town))
                {
                    salesReport.Add(sales[i].Town, 0);
                }

                salesReport[sales[i].Town] += sales[i].Price*sales[i].Quantity;
            }

            foreach (var currReport in salesReport)
            {
                Console.WriteLine("{0} -> {1:F2}", currReport.Key, currReport.Value);
            }
        }
    }

    public class Sale
    {
        public Sale(string town, string product, double price, double quantity)
        {
            this.Town = town;
            this.Product = product;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Town { get; set; }

        public string Product { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }
    }
}