using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double consumption;
        private double distance;

        public Car(string model, double fuelAmount, double consumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.Consumption = consumption;
            this.Distance = 0;
        }

        public bool CanDrive(double distance)
        {
            double fuelNeeded = distance * this.Consumption;

            if (this.FuelAmount < fuelNeeded)
            {
                return false;
            }

            this.FuelAmount -= fuelNeeded;
            this.Distance += distance;
            return true;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double Consumption { get; set; }
        public double Distance { get; set; }
    }
}
