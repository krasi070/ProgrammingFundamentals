namespace _03.BigFactorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = Factorial(n);
            Console.WriteLine(factorial);
        }

        private static BigInteger Factorial(BigInteger n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n*Factorial(n - 1);
        }
    }
}