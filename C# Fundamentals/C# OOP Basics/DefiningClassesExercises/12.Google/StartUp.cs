using System;
using System.Linq;
using System.Collections.Generic;

namespace Google
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                string name = input[0];
                if (people.ContainsKey(name) == false)
                {
                    people[name] = new Person(name);
                }

                switch (input[1])
                {
                    case "company":
                        string companyName = input[2];
                        string department = input[3];
                        decimal salary = decimal.Parse(input[4]);
                        Company company = new Company(companyName, department, salary);
                        people[name].Company = company;
                        break;
                    case "pokemon":
                        string pokemonName = input[2];
                        string type = input[3];
                        Pokemon pokemon = new Pokemon(pokemonName, type);
                        people[name].Pokemons.Add(pokemon);
                        break;
                    case "parents":
                        string parentName = input[2];
                        string parentBirthday = input[3];
                        Parent parent = new Parent(parentName, parentBirthday);
                        people[name].Parents.Add(parent);
                        break;
                    case "children":
                        string childName = input[2];
                        string childBirthday = input[3];
                        Child child = new Child(childName, childBirthday);
                        people[name].Children.Add(child);
                        break;
                    case "car":
                        string model = input[2];
                        int speed = int.Parse(input[3]);
                        Car car = new Car(model, speed);
                        people[name].Car = car;
                        break;
                }
            }

            string searchedName = Console.ReadLine();
            Person person = people.Values.FirstOrDefault(p => p.Name == searchedName);
            Console.WriteLine(person);
        }
    }
}
