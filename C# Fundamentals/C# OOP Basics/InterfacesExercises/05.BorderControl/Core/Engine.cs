using _05.BorderControl.Contracts;
using _05.BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BorderControl.Core
{
    public class Engine
    {
        //private List<IIdentifiable> creatures;
        //private List<IBirthable> birthdates;
        private List<IBuyer> buyers;
        public Engine()
        {
            //creatures = new List<IIdentifiable>();
            //birthdates = new List<IBirthable>();
            buyers = new List<IBuyer>();
        }
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 3)
                {
                    IBuyer rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                    buyers.Add(rebel);
                }
                else if (input.Length==4)
                {
                    IBuyer citizen = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                    buyers.Add(citizen);
                }
            }

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End")
                {
                    break;
                }

                foreach (var buyer in buyers)
                {
                    if (buyer.Name == name)
                    {
                        buyer.BuyFood();
                    }
                }
            }

            int totalFood = buyers.Sum(f => f.Food);
            Console.WriteLine(totalFood);

            //while (true)
            //{
            //    string[] input = Console.ReadLine().Split();
            //    if (input[0] == "End")
            //    {
            //        break;
            //    }

            //    string type = input[0];


            //    if (type == "Robot")
            //    {
            //        //robot
            //        string model = input[1];
            //        string id = input[2];
            //        IIdentifiable robot = new Robot(id, model);
            //        creatures.Add(robot);
            //    }
            //    else if (type == "Citizen")
            //    {
            //        //citizen
            //        string name = input[1];
            //        int age = int.Parse(input[2]);
            //        string id = input[3];
            //        string birthdate = input[4];

            //        IBirthable citizen = new Citizen(name, age, id, birthdate);
            //        birthdates.Add(citizen);
            //    }
            //    else if (type == "Pet")
            //    {
            //        string name = input[1];
            //        string birthdate = input[2];

            //        IBirthable pet = new Pet(name, birthdate);
            //        birthdates.Add(pet);
            //    }
            //}

            //string yearToCheck = Console.ReadLine();

            //foreach (var creature in birthdates.Where(x=>x.Birthdate.EndsWith(yearToCheck)))
            //{
            //    Console.WriteLine(creature.Birthdate);
            //}
        }
    }
}
