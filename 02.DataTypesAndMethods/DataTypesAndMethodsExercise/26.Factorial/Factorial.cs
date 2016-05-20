namespace _26.Factorial
{
    using System;
    using System.Numerics;

    public class Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorial(n));
        }

        private static BigInteger GetFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return GetFactorial(n - 1)*n;
        }
    }
}