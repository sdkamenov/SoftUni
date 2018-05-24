using System;

namespace Problem05.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int BPM = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());

            double bars = beats / 4.0;

            int min = beats/BPM;
            double sec = Math.Floor(60 * (beats / (double)BPM) - min * 60);
            Console.WriteLine($"{Math.Round(bars, 1)} bars - {min}m {sec}s");
        }
    }
}
