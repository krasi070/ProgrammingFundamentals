namespace _04.Elevator
{
    using System;

    public class Elevator
    {
        public static void Main()
        {
            decimal people = decimal.Parse(Console.ReadLine());
            decimal capacity = decimal.Parse(Console.ReadLine());
            decimal numberOfCourses = Math.Ceiling(people / capacity);
            Console.WriteLine("{0:F0}", numberOfCourses);
        }
    }
}