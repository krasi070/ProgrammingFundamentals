namespace _25.MasterNumbers
{
    using System;

    public class MasterNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 232; i <= number; i++)
            {
                if (IsPalindrome(i) && IsSumOfDigits(i) % 7 == 0 && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPalindrome(int number)
        {
            string num = number.ToString();
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static long IsSumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number%10;
                number /= 10;
            }

            return sum;
        }

        private static bool ContainsEvenDigit(int number)
        {
            while (number != 0)
            {
                int currDigit = number%10;
                if (currDigit % 2 == 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
}