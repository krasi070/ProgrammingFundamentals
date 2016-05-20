namespace _03.ExactSumOfRealNumbers
{
    using System;

    public class ExactSumOfRealNumbers
    {
        public static void Main()
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}