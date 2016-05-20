namespace _17.DifferentIntegerSize
{
    using System;

    public class DifferentIntegerSize
    {
        public static void Main()
        {
            string num = Console.ReadLine();

            try
            {
                long number = long.Parse(num);
                Console.WriteLine("{0} can fit in:", number);

                if (number >= -128 && number <= 127)
                {
                    Console.WriteLine("* sbyte");
                }

                if (number >= 0 && number <= 255)
                {
                    Console.WriteLine("* byte");
                }

                if (number >= -32768 && number <= 32767)
                {
                    Console.WriteLine("* short");
                }

                if (number >= 0 && number <= 65535)
                {
                    Console.WriteLine("* ushort");
                }

                if (number >= -2147483648 && number <= 2147483647)
                {
                    Console.WriteLine("* int");
                }

                if (number >= 0 && number <= 4294967295)
                {
                    Console.WriteLine("* uint");
                }

                Console.WriteLine("* long");
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't fit in any type", num);
            }
        }
    }
}