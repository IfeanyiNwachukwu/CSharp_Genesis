using System;
using System.Diagnostics;

namespace ForCSharp.DateTime
{
    public static class DateTimeSystems
    {
        public static void TimeSpanO()
        {
            TimeSpan timespan = new();
            Debug.WriteLine($"interval in Hours = {timespan.Hours}");

            TimeSpan timeSpan2 = new(1, 2, 0);

            Debug.WriteLine($"interval in Hours = {timeSpan2.Hours}");
            Debug.WriteLine($"interval in Minutes = {timeSpan2.Minutes}");
            Debug.WriteLine($"interval in Seconds = {timeSpan2.Seconds}");

            
        }

        public static void DateFormatting()
        {
            Debug.WriteLine(System.DateTime.Now.ToString("MM/dd/yyyy"));
            Debug.WriteLine(System.DateTime.Now.ToString("dddd/dd MMMM yyyy"));
        }

        public static void TimeFormatting()
        {
            Debug.WriteLine(System.DateTime.Now.ToString("dddd. dd MMMM yyyy HH:mm:ss"));
            Debug.WriteLine(System.DateTime.Now.ToString("dddd. dd MMMM yyyy HH:mm tt"));
        }

        public static void DateTimeConversion()
        {
            // Converting from Local to Universal Time Vice Versa
            Debug.WriteLine(System.DateTime.Now.ToUniversalTime().ToString("dddd. dd MMMM yyyy HH:mm:ss"));
            Debug.WriteLine(System.DateTime.UtcNow.ToLocalTime().ToString("dddd. dd MMMM yyyy HH:mm:ss"));

            // Knowing wether it is local or Universal Time
            Debug.WriteLine(System.DateTime.Now.Kind);
            Debug.WriteLine(System.DateTime.UtcNow.Kind);

            Debug.WriteLine(System.DateTime.Now);
            Debug.WriteLine(System.DateTime.UtcNow);

        }
    }
}
