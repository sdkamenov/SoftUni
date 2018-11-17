using _05.MordorsCruelPlan.Factories;
using _05.MordorsCruelPlan.Foods;
using _05.MordorsCruelPlan.Moods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.MordorsCruelPlan
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Food> foods = new List<Food>();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var foodName in input)
            {
                Food food = FoodFactory.GetFood(foodName);
                foods.Add(food);
            }

            Mood mood = MoodFactory.GetMood(foods);
            Console.WriteLine(foods.Sum(f=>f.PointsOfHappiness));
            Console.WriteLine(mood);
        }
    }
}
