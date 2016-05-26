namespace _04.SieveOfEratosthenes
{
    using System;

    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            bool[] primes = new bool[range + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            primes[0] = false;
            primes[1] = false;
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                    for (int j = 2; i*j < primes.Length; j++)
                    {
                        primes[i*j] = false;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}