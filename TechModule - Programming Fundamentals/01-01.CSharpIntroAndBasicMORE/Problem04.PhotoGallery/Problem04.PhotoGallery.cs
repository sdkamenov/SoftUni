using System;

namespace Problem04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int bytes = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{number:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hours:d2}:{minutes:d2}");

            if (bytes < 1000)
            {
                Console.WriteLine($"Size: {bytes}B");
            }
            else if (bytes < 1000000)
            {
                bytes /= 1000;
                Console.WriteLine($"Size: {bytes}KB");
            }
            else
            {
                bytes /= 1000000;
                Console.WriteLine($"Size: {bytes}MB");
            }

            if (width<height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else if (width>height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (width == height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
        }
    }
}
