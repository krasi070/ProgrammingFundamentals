namespace _13.Tour
{
    using System;
    using System.Linq;

    public class Tour
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            double[,] city = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                string[] currRow = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < size; j++)
                {
                    city[i, j] = double.Parse(currRow[j]);
                }
            }

            var sequenceOfCities = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            sequenceOfCities.Insert(0, 0);
            double distance = 0;
            for (int i = 0; i < sequenceOfCities.Count - 1; i++)
            {
                distance += city[sequenceOfCities[i], sequenceOfCities[i + 1]];
            }

            Console.WriteLine(distance);
        }
    }
}