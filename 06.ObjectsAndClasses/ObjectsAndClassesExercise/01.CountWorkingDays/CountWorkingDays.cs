namespace _08.CountWorkingDays
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class CountWorkingDays
    {
        public static void Main()
        {
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            List<DateTime> holidays = new List<DateTime>()
            {
                new DateTime(1, 1, 1),
                new DateTime(1, 3, 3),
                new DateTime(1, 5, 1),
                new DateTime(1, 5, 6),
                new DateTime(1, 5, 24),
                new DateTime(1, 9, 6),
                new DateTime(1, 9, 22),
                new DateTime(1, 11, 1),
                new DateTime(1, 12, 24),
                new DateTime(1, 12, 25),
                new DateTime(1, 12, 26)
            };

            int workingDaysCount = 0;
            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                bool isHoliday = false;
                for (int j = 0; j < holidays.Count; j++)
                {
                    if (i.Month == holidays[j].Month && i.Day == holidays[j].Day)
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday && i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDaysCount++;
                }
            }

            Console.WriteLine(workingDaysCount);
        }
    }
}