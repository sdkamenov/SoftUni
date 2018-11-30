﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammal
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            LivingRegion = livingRegion;
        }


        public string LivingRegion
        {
            get { return livingRegion; }
            set { livingRegion = value; }
        }
    }
}
