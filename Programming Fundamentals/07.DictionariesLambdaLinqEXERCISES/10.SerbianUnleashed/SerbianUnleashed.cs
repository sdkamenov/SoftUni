using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SerbianUnleashed
{
    class SerbianUnleashed
    {
        static void Main(string[] args)
        {
            var concerts = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var inputPattern = new Regex(@"(\D+)\s@(\D+)\s(\d+)\s(\d+)");
                var match = inputPattern.Match(input);

                if (match.Success)
                {
                    string singer = match.Groups[1].Value.Trim();
                    string venue = match.Groups[2].Value.Trim();
                    int ticketPrice = int.Parse(match.Groups[3].Value);
                    int ticketCount = int.Parse(match.Groups[4].Value);
                    int totalMoney = ticketPrice * ticketCount;

                    if (concerts.ContainsKey(venue) == false)
                    {
                        concerts.Add(venue, new Dictionary<string, int>());
                    }
                    if (concerts[venue].ContainsKey(singer) == false)
                    {
                        concerts[venue].Add(singer, 0);
                    }
                    concerts[venue][singer] += totalMoney;
                }
            }

            foreach (var concert in concerts)
            {
                Console.WriteLine(concert.Key);
                foreach (var artist in concert.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {artist.Key} -> {artist.Value}");
                }
            }
        }
    }
}
