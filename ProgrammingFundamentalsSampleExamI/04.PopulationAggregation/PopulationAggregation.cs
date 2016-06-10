namespace _04.PopulationAggregation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationAggregation
    {
        public static void Main()
        {
            SortedDictionary<string, int> countries = new SortedDictionary<string, int>();
            Dictionary<string, long> towns = new Dictionary<string, long>();

            string line = Console.ReadLine();
            while (line != "stop")
            {
                string[] args = line.Split('\\');
                string firstArg = ClearString(args[0]);
                string secondArg = ClearString(args[1]);
                string country = firstArg[0] >= 'A' && firstArg[0] <= 'Z' ? firstArg : secondArg;
                string town = firstArg[0] >= 'A' && firstArg[0] <= 'Z' ? secondArg : firstArg;
                long population = long.Parse(args[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, 0);
                }

                countries[country]++;

                if (!towns.ContainsKey(town))
                {
                    towns.Add(town, 0);
                }

                towns[town] = population;

                line = Console.ReadLine();
            }

            towns = towns
                .OrderByDescending(t => t.Value)
                .Take(3)
                .ToDictionary(t => t.Key, t => t.Value);

            foreach (var country in countries)
            {
                Console.WriteLine("{0} -> {1}", country.Key, country.Value);
            }

            foreach (var town in towns)
            {
                Console.WriteLine("{0} -> {1}", town.Key, town.Value);
            }
        }

        private static string ClearString(string str)
        {
            string clearStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (!(str[i] == '@' || 
                    str[i] == '#' || 
                    str[i] == '$' || 
                    str[i] == '&' || 
                    (str[i] >= '0' && str[i] <= '9')))
                {
                    clearStr += str[i].ToString();
                }
            }

            return clearStr;
        }
    }
}