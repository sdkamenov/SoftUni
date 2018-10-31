using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);

                if (input.Length == 2)
                {
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }
                else if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int result))
                    {
                        Engine engine = new Engine(model, power);
                        engine.Displacement = result;
                        engines.Add(engine);
                    }
                    else
                    {
                        Engine engine = new Engine(model, power);
                        engine.Efficiency = input[2];
                        engines.Add(engine);
                    }
                }
                else if (input.Length == 4)
                {
                    Engine engine = new Engine(model, power);
                    engine.Displacement = int.Parse(input[2]);
                    engine.Efficiency = input[3];
                    engines.Add(engine);
                }
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int j = 0; j < m; j++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engineModel = input[1];

                Engine engine = engines.First(e => e.Model == engineModel);

                if (input.Length == 2)
                {
                    Car car = new Car(model, engine);
                    cars.Add(car);
                }
                else if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int result))
                    {
                        Car car = new Car(model, engine);
                        car.Weight = result;
                        cars.Add(car);
                    }
                    else
                    {
                        Car car = new Car(model, engine);
                        car.Color = input[2];
                        cars.Add(car);
                    }
                }
                else if (input.Length == 4)
                {
                    Car car = new Car(model, engine);
                    car.Weight = int.Parse(input[2]);
                    car.Color = input[3];
                    cars.Add(car);
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == -1)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                if (car.Weight == -1)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
