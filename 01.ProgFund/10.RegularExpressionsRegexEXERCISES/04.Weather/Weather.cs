using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, KeyValuePair<double, string>>();

            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                Match match = regex.Match(input);

                if (match.Success == false)
                {
                    continue;
                }

                string city = match.Groups[1].Value;
                double temp = double.Parse(match.Groups[2].Value);
                string type = match.Groups[3].Value;

                if (cities.ContainsKey(city) ==false)
                {
                    cities.Add(city, new KeyValuePair<double, string>(temp, type));
                }
                else
                {
                    cities[city] = new KeyValuePair<double, string>(temp, type);
                }
            }

            foreach (var city in cities.OrderBy(c => c.Value.Key))
            {
                Console.WriteLine($"{city.Key} => {city.Value.Key:f2} => {city.Value.Value}");
            }
        }
    }
}
