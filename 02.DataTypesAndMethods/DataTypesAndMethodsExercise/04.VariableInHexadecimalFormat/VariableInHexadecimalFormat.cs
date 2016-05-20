namespace _04.VariableInHexadecimalFormat
{
    using System;

    public class VariableInHexadecimalFormat
    {
        public static void Main()
        {
            string hexNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToInt64(hexNumber, 16));
        }
    }
}