using _10.ExplicitInterfaces.Contracts;
using _10.ExplicitInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _10.ExplicitInterfaces.Core
{
    public class Engine
    {
        private IPerson person;
        private IResident resident;
        public Engine()
        {

        }
        public void Run()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                person = new Citizen(name, country, age);
                resident = new Citizen(name, country, age);

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
