using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);

                List<Tire> tires = new List<Tire>();
                for (int j = 5; j < input.Length; j+=2)
                {
                    Tire tire = new Tire(double.Parse(input[j]), int.Parse(input[j + 1]));
                    tires.Add(tire);
                }

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }


            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.Cargo.Type == command)
                    .Where(t => t.Tires.Any(p => p.Pressure < 1))
                    .Select(m => m.Model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
            else if (command == "flamable")
            {
                cars.Where(c => c.Cargo.Type == command)
                    .Where(e=>e.Engine.Power > 250)
                    .Select(m => m.Model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
        }
    }
}
