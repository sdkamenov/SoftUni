using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexLab1862018
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> venueSingerMoney = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;

                }

                string[] elements = input.Split("@").ToArray();
                string singer = elements[0].Trim();
                var splitedElements1 = elements[1].Trim().Split(' ').ToArray();
                string[] venueArray = splitedElements1.Take(splitedElements1.Length - 2).ToArray();
                bool isValidInput = input.Split(' ').ToArray().Length >= 4 && venueArray.Length <= 3;
                if (isValidInput)
                {
                    string venueAsStr = string.Join(' ', venueArray);
                    string[] ticketPriceAsArray = splitedElements1.Skip(venueArray.Length).Take(1).ToArray();
                    string ticketPriceAsStr = string.Join("", ticketPriceAsArray);
                    int ticketPrice = int.Parse(ticketPriceAsStr);
                    string[] ticketCountAsArray = splitedElements1.Skip(venueArray.Length + 1).Take(1).ToArray();
                    string ticketCountAsStr = string.Join("", ticketCountAsArray);
                    int ticketCount = int.Parse(ticketCountAsStr);
                    if (!venueSingerMoney.ContainsKey(venueAsStr))
                    {
                        venueSingerMoney.Add(venueAsStr, new Dictionary<string, long>());
                    }
                    if (!venueSingerMoney[venueAsStr].ContainsKey(singer))
                    {
                        venueSingerMoney[venueAsStr].Add(singer, 0);
                    }
                    venueSingerMoney[venueAsStr][singer] += ticketCount * ticketPrice;
                }
            }
            foreach (var venueSingerMoneyKVP in venueSingerMoney)
            {
                Console.WriteLine($"{venueSingerMoneyKVP.Key}");
                foreach (var nestedKVP in venueSingerMoney[venueSingerMoneyKVP.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {nestedKVP.Key} -> {nestedKVP.Value}");
                }
            }
            Console.WriteLine();
        }
    }
}