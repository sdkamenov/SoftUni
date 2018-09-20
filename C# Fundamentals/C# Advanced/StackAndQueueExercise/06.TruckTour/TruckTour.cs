using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            //            Suppose there is a circle. There are N petrol pumps on that circle. Petrol pumps are numbered 0 to(N−1)(both inclusive).You have two pieces of information corresponding to each of the petrol pump: (1) the amount of petrol that particular petrol pump will give, and (2) the distance from that petrol pump to the next petrol pump.
            //Initially, you have a tank of infinite capacity carrying no petrol. You can start the tour at any of the petrol pumps.Calculate the first point from where the truck will be able to complete the circle. Consider that the truck will stop at each of the petrol pumps. The truck will move one kilometer for each liter of the petrol.

            int n = int.Parse(Console.ReadLine());
            int minIndex = 0;
            int fuel = 0;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int amountPetrol = input[0];
                int distance = input[1];

                fuel += amountPetrol - distance;

                if (fuel < 0)
                {
                    fuel = 0;
                    minIndex = i + 1;
                }
            }
            Console.WriteLine(minIndex);
        }
    }
}
