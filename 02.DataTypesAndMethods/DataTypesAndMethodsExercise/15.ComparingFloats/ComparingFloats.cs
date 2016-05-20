namespace _15.ComparingFloats
{
    using System;

    public class ComparingFloats
    {
        public static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal diff = Math.Abs(a - b);
            Console.WriteLine(diff < 0.000001m);
        }
    }
}