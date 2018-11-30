using System;

namespace Vehicles.Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditionersConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            FuelConsumption += airConditionersConsumption;
        }

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }

            if (FuelQuantity + fuel > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            FuelQuantity += fuel * 0.95;
        }
    }
}
