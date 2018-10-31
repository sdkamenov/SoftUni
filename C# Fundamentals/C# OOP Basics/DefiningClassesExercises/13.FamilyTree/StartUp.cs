using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
    public class StartUp
    {
        static List<Person> people;
        static List<string> realationships;
        static void Main(string[] args)
        {
            people = new List<Person>();
            realationships = new List<string>();

            string mainPersonInfo = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "End")
            {
                if (!input.Contains("-"))
                {
                    AddMember(input);
                    input = Console.ReadLine();
                    continue;
                }

                realationships.Add(input);
                input = Console.ReadLine();
            }

            foreach (var member in realationships)
            {
                string[] tokens = member.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                Person parent = GerPerson(tokens[0]);
                Person child = GerPerson(tokens[1]);

                if (!parent.Children.Contains(child))
                {
                    parent.Children.Add(child);
                }
                if (!child.Parents.Contains(parent))
                {
                    child.Parents.Add(parent);
                }
            }

            Print(mainPersonInfo);
        }

        private static void Print(string mainPersonInfo)
        {
            Person mainPerson = GerPerson(mainPersonInfo);

            Console.WriteLine($"{mainPerson.Name} {mainPerson.Birthday}");
            Console.WriteLine("Parents:");

            foreach (var parent in mainPerson.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");
            }

            Console.WriteLine($"Children:");
            foreach (var child in mainPerson.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }

        private static Person GerPerson(string input)
        {
            if (input.Contains("/"))
            {
                return people.FirstOrDefault(x => x.Birthday == input);
            }
            return people.FirstOrDefault(x => x.Name == input);
        }

        private static void AddMember(string input)
        {
            string[] inputArgs = input.Split();
            string name = inputArgs[0] + " " + inputArgs[1];
            string birthday = inputArgs[2];

            Person person = new Person(name, birthday);
            people.Add(person);
        }
    }
}
