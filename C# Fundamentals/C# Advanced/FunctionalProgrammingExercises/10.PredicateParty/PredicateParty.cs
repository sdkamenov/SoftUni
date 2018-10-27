using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class PredicateParty
    {
        static void Main(string[] args)
        {
            Action<List<string>> print = names => Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            Predicate<string> predicate;
            List<string> guests = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Party!")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];
                string predicateName = tokens[1];
                string value = tokens[2];

                predicate = GetPredicate(predicateName, value);

                if (command == "Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else
                {
                   var newGuests = guests.FindAll(predicate);

                    foreach (var guest in newGuests)
                    {
                        int indexOfCurrentGuest = guests.IndexOf(guest);
                        guests.Insert(indexOfCurrentGuest + 1, guest);
                    }
                }
            }

            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                print(guests);
            }
        }

        private static Predicate<string> GetPredicate(string predicateName, string value)
        {
            if (predicateName == "StartsWith")
            {
                return p => p.StartsWith(value);
            }
            else if (predicateName == "EndsWith")
            {
                return p => p.EndsWith(value);
            }
            else if (predicateName == "Length")
            {
                return p => p.Length == int.Parse(value);
            }

            return null;
        }
    }
}
