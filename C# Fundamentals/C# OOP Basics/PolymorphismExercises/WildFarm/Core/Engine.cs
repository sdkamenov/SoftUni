using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Animals.Birds.Factory;
using WildFarm.Animals.Mammal.Factory;
using WildFarm.Animals.Mammal.Felines.Factory;
using WildFarm.Foods.Factory;

namespace WildFarm.Core
{
    public class Engine
    {
        private BirdFactory birdFactory;
        private FelineFactory felineFactory;
        private MammalFactory mammalFactory;
        private FoodFactory foodFactory;
        private Animal animal;
        private List<Animal> animals;
        public Engine()
        {
            birdFactory = new BirdFactory();
            felineFactory = new FelineFactory();
            mammalFactory = new MammalFactory();
            foodFactory = new FoodFactory();
            animals = new List<Animal>();
        }
        public void Run()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {

                string[] animalInfo = input.Split();
                string[] foodInfo = Console.ReadLine().Split();

                string animalType = animalInfo[0];
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);

                if (animalType == "Hen" || animalType == "Owl")
                {
                    double wingSize = double.Parse(animalInfo[3]);
                    animal = birdFactory.CreateBird(animalType, name, weight, wingSize);
                }
                else if (animalType == "Dog" || animalType == "Mouse")
                {
                    string livingRegion = animalInfo[3];
                    animal = mammalFactory.CreateMammal(animalType, name, weight, livingRegion);
                }
                else if (animalType == "Cat" || animalType == "Tiger")
                {
                    string livingRegion = animalInfo[3];
                    string breed = animalInfo[4];
                    animal = felineFactory.CreateFeline(animalType, name, weight, livingRegion, breed);
                }

                string foodType = foodInfo[0];
                int quantity = int.Parse(foodInfo[1]);
                var food = foodFactory.CreateFood(foodType, quantity);

                animal.ProduceSound();
                animal.Eat(food);

                animals.Add(animal);

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
