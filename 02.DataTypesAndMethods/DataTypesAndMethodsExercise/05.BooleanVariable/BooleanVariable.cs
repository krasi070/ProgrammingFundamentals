namespace _05.BooleanVariable
{
    using System;

    public class BooleanVariable
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            Console.WriteLine(Convert.ToBoolean(str) ? "Yes" : "No");
        }
    }
}