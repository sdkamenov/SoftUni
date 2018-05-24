using System;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cheese = 0;
            int tomatoSause = 0;
            int salami = 0;
            int pepper = 0;
            for (int i = 1; i <= n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    cheese++;
                }
                else if (ingredient == "tomato sauce")
                {
                    tomatoSause++;
                }
                else if (ingredient == "salami")
                {
                    salami++;
                }
                else if (ingredient == "pepper")
                {
                    pepper++;
                }
            }

            int totalCal = cheese * 500 + tomatoSause * 150 + pepper * 50 + salami * 600;

            Console.WriteLine($"Total calories: {totalCal}");
        }
    }
}
