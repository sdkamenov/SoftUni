using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double consumption = double.Parse(tokens[2]);

                Car car = new Car(model, fuelAmount, consumption);
                cars.Add(car);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                string carModel = input[1];
                double km = double.Parse(input[2]);

                Car carToDrive = cars.Find(c => c.Model == carModel);
                bool canMove = carToDrive.CanDrive(km);

                if (canMove == false)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
            }
        }
    }
}
