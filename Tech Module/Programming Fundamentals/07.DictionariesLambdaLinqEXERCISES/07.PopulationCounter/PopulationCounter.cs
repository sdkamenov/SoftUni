using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var totalPopulation = new Dictionary<string, long>();
            var countriesAndCities = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "report")
                {
                    break;
                }

                string[] tokens = input.Split('|');
                string city = tokens[0];
                string country = tokens[1];
                long poputaion = long.Parse(tokens[2]);


                if (totalPopulation.ContainsKey(country) == false)
                {
                    totalPopulation.Add(country, 0);
                    countriesAndCities.Add(country, new Dictionary<string, long>());
                }

                totalPopulation[country] += poputaion;
                countriesAndCities[country].Add(city, poputaion);
            }
            foreach (var country in totalPopulation.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

                var cities = countriesAndCities[country.Key]
                    .OrderByDescending(c => c.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
