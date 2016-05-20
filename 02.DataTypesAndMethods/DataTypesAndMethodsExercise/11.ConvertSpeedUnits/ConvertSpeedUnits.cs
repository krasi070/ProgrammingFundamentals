namespace _11.ConvertSpeedUnits
{
    using System;

    public class ConvertSpeedUnits
    {
        public static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeInSeconds = hours * 3600f + minutes * 60f + seconds;
            float timeInHours = hours + minutes / 60f + seconds / 3600f;
            float distanceInKilometers = distanceInMeters / 1000f;
            float distanceInMiles = distanceInMeters / 1609f;

            float metersPerSecond = distanceInMeters / timeInSeconds;
            float kilometersPerHour = distanceInKilometers / timeInHours;
            float milesPerHour = distanceInMiles / timeInHours;

            Console.WriteLine("{0}\n{1}\n{2}", metersPerSecond, kilometersPerHour, milesPerHour);
        }
    }
}