namespace _04.DistanceBetweenPoints
{
    using System;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            string[] firstPoint = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Point pointA = new Point(int.Parse(firstPoint[0]), int.Parse(firstPoint[1]));

            string[] secondPoint = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Point pointB = new Point(int.Parse(secondPoint[0]), int.Parse(secondPoint[1]));

            double distance = CalculateDistance(pointA, pointB);
            Console.WriteLine("{0:F3}", distance);
        }

        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double distance = Math.Sqrt(
                    Math.Pow(firstPoint.X - secondPoint.X, 2) +
                    Math.Pow(firstPoint.Y - secondPoint.Y, 2));

            return distance;
        }
    }

    public class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }
    }
}