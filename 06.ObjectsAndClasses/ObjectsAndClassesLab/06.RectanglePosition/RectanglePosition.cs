namespace _06.RectanglePosition
{
    using System;

    public class RectanglePosition
    {
        public static void Main()
        {
            string[] firstRectangleArgs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Rectangle rectangleA = new Rectangle(
                double.Parse(firstRectangleArgs[0]),
                double.Parse(firstRectangleArgs[1]),
                double.Parse(firstRectangleArgs[2]),
                double.Parse(firstRectangleArgs[3]));
            string[] secondRectangleArgs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Rectangle rectangelB = new Rectangle(
                double.Parse(secondRectangleArgs[0]),
                double.Parse(secondRectangleArgs[1]),
                double.Parse(secondRectangleArgs[2]),
                double.Parse(secondRectangleArgs[3]));

            bool isInside = IsRectangleInside(rectangleA, rectangelB);
            Console.WriteLine(isInside ? "Inside" : "Not inside");
        }

        private static bool IsRectangleInside(Rectangle rectangleA, Rectangle rectangleB)
        {
            return rectangleA.X >= rectangleB.X &&
                   rectangleA.X + rectangleA.Width <= rectangleB.X + rectangleB.Width &&
                   rectangleA.Y <= rectangleB.Y &&
                   rectangleA.Y - rectangleA.Height >= rectangleB.Y - rectangleB.Height;
        }
    }

    public class Rectangle
    {
        public Rectangle(double x, double y, double width, double height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }
    }
}