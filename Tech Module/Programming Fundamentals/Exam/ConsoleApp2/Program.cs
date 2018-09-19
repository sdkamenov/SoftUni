using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;

namespace Problem03
{
    class Problem03
    {
        static void Main(string[] args)
        {
            string pattern = @"\%([A-Z][a-z]+)\%\<([A-Z][a-z]+)\>([A-Za-z])*?\|([0-9]+)\|([A-Za-z])*?([0-9]+\.?[0-9]+?)";
            Regex regex = new Regex(pattern);
            double sum = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }

                Dictionary<string, KeyValuePair<string, double>> opaaa = new Dictionary<string, KeyValuePair<string, double>>();
                MatchCollection matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    string name = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    double count = double.Parse(match.Groups[4].Value);
                    double price = double.Parse(match.Groups[6].Value);

                    double totalPrice = count * price;

                    if (opaaa.ContainsKey(name) == false)
                    {
                        opaaa.Add(name, new KeyValuePair<string, double>(product, totalPrice));
                    }
                    else
                    {
                        opaaa[name] = new KeyValuePair<string, double>(product, totalPrice);
                    }

                    foreach (var que in opaaa)
                    {
                        Console.WriteLine($"{que.Key}: {que.Value.Key} - {que.Value.Value:f2}");
                        sum += totalPrice;
                    }
                }

            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
