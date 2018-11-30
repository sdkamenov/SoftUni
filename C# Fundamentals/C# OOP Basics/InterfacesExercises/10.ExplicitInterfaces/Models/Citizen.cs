﻿using _10.ExplicitInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _10.ExplicitInterfaces.Models
{
    public class Citizen : IPerson, IResident
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Country { get; private set; }


        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }
        string IPerson.GetName()
        {
            return Name;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }
    }
}
