using System;

namespace _05.PizzaCalories
{
    public class Toppings
    {
        private string type;
        private int weight;

        public Toppings()
        {

        }
        public Toppings(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;
            set
            {
                if (value.ToLower() != "meat"
                    && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese"
                    && value.ToLower() != "sauce")
                {
                    string type = Char.ToUpper(value[0]) + value.Substring(1);
                    Exception ex = new ArgumentException($"Cannot place {type} on top of your pizza.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                type = value;
            }
        }

        public int Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    string type = Char.ToUpper(this.Type[0]) + this.Type.Substring(1);
                    Exception ex = new ArgumentException($"{type} weight should be in the range [1..50].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                weight = value;
            }
        }

        public double ToppingCalories { get => this.CalculateToppingCalories(); }
        private double CalculateToppingCalories()
        {
            double modifier =
                this.Type == "meat" ? 1.2 :
                this.Type == "veggies" ? 0.8 :
                this.Type == "cheese" ? 1.1 : 0.9;
            return this.Weight * 2 * modifier;
        }
    }
}
