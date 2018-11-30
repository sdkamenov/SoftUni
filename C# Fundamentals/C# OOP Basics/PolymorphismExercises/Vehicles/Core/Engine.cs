using System;
using Vehicles.Vehicles;
using Vehicles.Vehicles.Contracts;

namespace Vehicles.Core
{
    public class Engine
    {
        public Engine()
        {

        }

        //public void RunFirstProblem()
        //{
        //    string[] carInfo = Console.ReadLine().Split();
        //    double carFuelQuantity = double.Parse(carInfo[1]);
        //    double carFuelConsumption = double.Parse(carInfo[2]);

        //    string[] truckInfo = Console.ReadLine().Split();
        //    double truckFuelQuantity = double.Parse(truckInfo[1]);
        //    double truckFuelConsumption = double.Parse(truckInfo[2]);

        //    IVehicle car = new Car(carFuelQuantity, carFuelConsumption);
        //    IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);


        //    int n = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < n; i++)
        //    {
        //        try
        //        {
        //            string[] tokens = Console.ReadLine().Split();
        //            string action = tokens[0];
        //            string vehicleType = tokens[1];
        //            double value = double.Parse(tokens[2]);

        //            if (action == "Drive")
        //            {
        //                if (vehicleType == "Car")
        //                {
        //                    car.Drive(value);
        //                }
        //                else
        //                {
        //                    truck.Drive(value);
        //                }

        //            }
        //            else
        //            {
        //                if (vehicleType == "Car")
        //                {
        //                    car.Refuel(value);
        //                }
        //                else
        //                {
        //                    truck.Refuel(value);
        //                }
        //            }
        //        }
        //        catch (ArgumentException ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }

        //    Console.WriteLine(car);
        //    Console.WriteLine(truck);
        //}

        public void RunSecondProblem()
        {
            string[] carInfo = Console.ReadLine().Split();
            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            string[] truckInfo = Console.ReadLine().Split();
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            string[] busInfo = Console.ReadLine().Split();
            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);


            IVehicle car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            IVehicle bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] tokens = Console.ReadLine().Split();
                    string action = tokens[0];
                    string vehicleType = tokens[1];
                    double value = double.Parse(tokens[2]);

                    if (action == "Drive")
                    {
                        if (vehicleType == "Car")
                        {
                            car.Drive(value);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Drive(value);
                        }
                        else if(vehicleType == "Bus")
                        {
                            bus.IsVehicleEmpty = false;
                            bus.Drive(value);
                        }

                    }
                    else if (action == "Refuel")
                    {
                        if (vehicleType == "Car")
                        {
                            car.Refuel(value);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Refuel(value);
                        }
                        else if(vehicleType == "Bus")
                        {
                            bus.Refuel(value);
                        }
                    }
                    else if (action == "DriveEmpty")
                    {
                        bus.IsVehicleEmpty = true;
                        bus.Drive(value);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
