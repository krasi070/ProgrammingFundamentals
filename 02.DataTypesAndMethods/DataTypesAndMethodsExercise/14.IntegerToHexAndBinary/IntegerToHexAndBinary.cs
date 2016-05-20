namespace _14.IntegerToHexAndBinary
{
    using System;

    public class IntegerToHexAndBinary
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(number, 2);
            string hexadecimalNumber = Convert.ToString(number, 16);
            Console.WriteLine("{0}\n{1}", hexadecimalNumber.ToUpper(), binaryNumber);
        }
    }
}