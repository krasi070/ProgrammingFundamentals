namespace _23.PrimeChecker
{
    using System;

    public class PrimeChecker
    {
        public static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        private static bool IsPrime(ulong number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (ulong i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}