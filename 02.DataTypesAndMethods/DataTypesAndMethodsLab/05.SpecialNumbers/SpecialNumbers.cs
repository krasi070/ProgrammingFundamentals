namespace _05.SpecialNumbers
{
    using System;

    public class SpecialNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int currNumber = i;
                int sumOfDigits = 0;
                while (currNumber != 0)
                {
                    sumOfDigits += currNumber % 10;
                    currNumber /= 10;
                }

                bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
                Console.WriteLine("{0} -> {1}", i, isSpecial);
            }
        }
    }
}