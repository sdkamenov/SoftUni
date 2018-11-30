using _05.BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BorderControl.Models
{
    public class Pet : IBirthable
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get => name; set => name = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
    }
}
