using System;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        double volume = double.Parse(Console.ReadLine());
        double energyPer100 = double.Parse(Console.ReadLine());
        double sugarPer100 = double.Parse(Console.ReadLine());
        double energyPerVolume = energyPer100 * volume / 100.0;
        double sugarPerVolume = sugarPer100 * volume / 100.0;

        Console.WriteLine($"{volume}ml {name}:\n{energyPerVolume}kcal, {sugarPerVolume}g sugars");
    }
}