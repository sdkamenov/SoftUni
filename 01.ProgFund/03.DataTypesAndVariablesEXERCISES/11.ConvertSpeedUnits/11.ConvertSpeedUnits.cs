using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceM = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int secondsConverted = (((hours * 60) * 60) + minutes * 60 + seconds);
            float metersPerSecond = ((float)distanceM / (float)secondsConverted);
            double hoursConverted = (hours + ((double)minutes / 60) + ((double)((double)seconds / 60) / 60));
            float kmPerHour = (((float)distanceM / 1000) / (float)hoursConverted);
            float milesPerHour = (float)((double)distanceM / (double)1609) / (float)hoursConverted;

            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kmPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
