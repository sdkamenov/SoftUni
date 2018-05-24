using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPicturesTaken = int.Parse(Console.ReadLine());
            long filterTimeSeconds = int.Parse(Console.ReadLine());
            long filterFactor = int.Parse(Console.ReadLine());
            long uploadTime = int.Parse(Console.ReadLine());
            
            long totalFilterTime = numberOfPicturesTaken * filterTimeSeconds;
            long goodPictures = (long)Math.Ceiling(numberOfPicturesTaken * filterFactor / 100.0);
            long totalUploadTime = goodPictures * uploadTime;
            
            long totalTime = totalFilterTime + totalUploadTime;

            TimeSpan picturesReadyInTime = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine($"{picturesReadyInTime.Days:d1}:{picturesReadyInTime.Hours:d2}:{picturesReadyInTime.Minutes:d2}:{picturesReadyInTime.Seconds:d2}");
        }
    }
}
