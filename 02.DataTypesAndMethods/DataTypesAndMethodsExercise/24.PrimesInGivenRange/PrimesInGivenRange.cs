namespace _24.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesInGivenRange
    {
        public static void Main()
        {
            ulong start = ulong.Parse(Console.ReadLine());
            ulong end = ulong.Parse(Console.ReadLine());

            List<ulong> primes = GetPrimesInRange(start, end);
            if (primes.Count != 0)
            {
                Console.WriteLine(string.Join(", ", primes));
            }
            else
            {
                Console.WriteLine("(empty list)");
            }

        }

        private static List<ulong> GetPrimesInRange(ulong start, ulong end)
        {
            var primes = new List<ulong>();
            for (ulong i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
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