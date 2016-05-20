namespace _12.RectangleProperties
{
    using System;

    public class RectangleProperties
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double perimeter = 2*a + 2*b;
            double area = a*b;
            double diagonal = Math.Sqrt(a*a + b*b);
            Console.WriteLine("{0}\n{1}\n{2}", perimeter, area, diagonal);
        }
    }
}