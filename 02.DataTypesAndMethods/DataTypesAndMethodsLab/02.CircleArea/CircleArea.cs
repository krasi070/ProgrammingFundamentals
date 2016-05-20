namespace _02.CircleArea
{
    using System;

    public class CircleArea
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = radius * radius * Math.PI;
            Console.WriteLine("{0:F12}", area);
        }
    }
}