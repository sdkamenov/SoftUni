using System;
using System.Collections.Generic;
using System.Text;

namespace _05.PizzaCalories
{
    public class Dough
    {
        private string flour;
        private string bakingTechnique;
        private int weight;

        public Dough()
        {

        }
        public Dough(string flour, string bakingTechnique, int weight)
        {
            Flour = flour;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string Flour
        {
            get => flour;
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    Exception ex = new ArgumentException("Invalid type of dough.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                flour = value.ToLower();
            }
        }
        public string BakingTechnique
        {
            get => bakingTechnique;
            set
            {
                if (value.ToLower() != "crispy" 
                    && value.ToLower() != "chewy" 
                    && value.ToLower() != "homemade")
                {
                    Exception ex = new ArgumentException("Invalid type of dough.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                bakingTechnique = value.ToLower();
            }
        }

        public int Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 200)
                {
                    Exception ex = new ArgumentException("Dough weight should be in the range [1..200].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                weight = value;
            }
        }

        public double DoughCalories { get => this.CalculateDoughCalories(); }
        private double CalculateDoughCalories()
        {
            double flourModifier = this.Flour == "white" ? 1.5 : 1.0;
            double bakingModifier = this.BakingTechnique == "crispy" ? 0.9 : this.BakingTechnique == "chewy" ? 1.1 : 1.0;
            return this.Weight * 2 * flourModifier * bakingModifier;
        }
    }
}
