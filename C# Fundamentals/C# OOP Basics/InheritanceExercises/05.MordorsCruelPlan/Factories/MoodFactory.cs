﻿using _05.MordorsCruelPlan.Foods;
using _05.MordorsCruelPlan.Moods;
using System.Collections.Generic;
using System.Linq;

namespace _05.MordorsCruelPlan.Factories
{
    public class MoodFactory
    {
        public static Mood GetMood(List<Food> foods)
        {
            int totalPoints = foods.Sum(f => f.PointsOfHappiness);

            if (totalPoints < -5)
            {
                return new Angry();
            }
            else if (totalPoints >= -5 && totalPoints <= 0)
            {
                return new Sad();
            }
            else if (totalPoints >=1 && totalPoints < 15)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();
            }
        }
    }
}
