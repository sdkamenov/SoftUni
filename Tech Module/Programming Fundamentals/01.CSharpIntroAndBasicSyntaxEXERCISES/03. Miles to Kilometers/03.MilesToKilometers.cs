﻿using System;

class Program
{
    static void Main()
    {
        double miles = double.Parse(Console.ReadLine());
        double km = miles * 1.60934;
        Console.WriteLine($"{km:f2}");
    }
}