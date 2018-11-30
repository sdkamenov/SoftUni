using _05.BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BorderControl.Models
{
    public class Rebel : IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = 0;
        }

        public string Name { get; }
        public int Age { get; }
        public string Group { get; }
        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
