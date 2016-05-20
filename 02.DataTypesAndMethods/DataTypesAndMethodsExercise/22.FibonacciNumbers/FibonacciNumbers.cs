namespace _22.FibonacciNumbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciNumber(n));
        }

        private static int GetFibonacciNumber(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            int fib1 = 1;
            int fib2 = 1;
            for (int i = 2; i <= n; i++)
            {
                int fib3 = fib2;
                fib2 = fib1 + fib2;
                fib1 = fib3;
            }

            return fib2;
        }
    }
}