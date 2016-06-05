namespace _05.ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            for (int i = 0; i < numberOfPoints; i++)
            {
                string[] currPoint = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Point point = new Point(int.Parse(currPoint[0]), int.Parse(currPoint[1]));
                points.Add(point);
            }

            Point firstPoint = null;
            Point secondPoint = null;
            double shortestDistance = double.MaxValue;
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    double currDistance = CalculateDistance(points[i], points[j]);
                    if (currDistance < shortestDistance)
                    {
                        shortestDistance = currDistance;
                        firstPoint = points[i];
                        secondPoint = points[j];
                    }
                }
            }

            Console.WriteLine(
                "{0:F3}{1}({2}, {3}){1}({4}, {5})", 
                shortestDistance,
                Environment.NewLine,
                firstPoint.X,
                firstPoint.Y,
                secondPoint.X,
                secondPoint.Y);
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