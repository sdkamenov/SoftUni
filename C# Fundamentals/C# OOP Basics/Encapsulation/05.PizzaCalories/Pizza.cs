using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Toppings> toppings;

        public Pizza()
        {
            this.Toppings = new List<Toppings>();
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    Exception ex = new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                name = value;
            }
        }
        public Dough Dough { get => dough; set => dough = value; }
        public List<Toppings> Toppings
        {
            get => toppings;
            private set
            {
                this.toppings = value;
            }
        }

        public double CaloriesGet { get => GetCalories(); }
        private double GetCalories()
        {
            double doughCalories = this.Dough.DoughCalories;
            double toppingCalories = this.Toppings.Sum(c =>c.ToppingCalories);
            return doughCalories + toppingCalories;
        }
        public void Add(Toppings topping)
        {
            this.Toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.CaloriesGet:f2} Calories.";
        }
    }
}
