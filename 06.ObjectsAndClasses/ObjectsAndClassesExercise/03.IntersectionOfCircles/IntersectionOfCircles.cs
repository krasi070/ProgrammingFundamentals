namespace _03.IntersectionOfCircles
{
    using System;

    public class IntersectionOfCircles
    {
        public static void Main()
        {
            string[] circleAArgs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            double circleAX = double.Parse(circleAArgs[0]);
            double circleAY = double.Parse(circleAArgs[1]);
            double circleARadius = double.Parse(circleAArgs[2]);
            Circle circleA = new Circle(circleAX, circleAY, circleARadius);
            string[] circleBArgs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            double circleBX = double.Parse(circleBArgs[0]);
            double circleBY = double.Parse(circleBArgs[1]);
            double circleBRadius = double.Parse(circleBArgs[2]);
            Circle circleB = new Circle(circleBX, circleBY, circleBRadius);

            bool circlesIntersect = circleA.Intersect(circleB);
            Console.WriteLine(circlesIntersect ? "Yes" : "No");
        }
    }

    public class Circle
    {
        public Circle(double x, double y, double radius)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Radius { get; set; }

        public bool Intersect(Circle other)
        {
            double distance = this.CalculateDistanceBetweenCenters(other);

            return distance <= this.Radius + other.Radius;
        }

        private double CalculateDistanceBetweenCenters(Circle other)
        {
            double distance = Math.Sqrt(Math.Pow(other.X - this.X, 2) + Math.Pow(other.Y - this.Y, 2));

            return distance;
        }
    }
}