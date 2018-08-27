using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "A":
                        string name = tokens[1];
                        string phone = tokens[2];
                        if (phonebook.ContainsKey(name))
                        {
                            phonebook[name] = phone;
                        }
                        else
                        {
                            phonebook.Add(name, phone);
                        }
                        break;
                    case "S":
                        string searchedName = tokens[1];
                        if (phonebook.ContainsKey(searchedName))
                        {
                            string foundNumber = phonebook[searchedName];
                            Console.WriteLine($"{searchedName} -> {foundNumber}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {searchedName} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var contact in phonebook)
                        {
                            Console.WriteLine($"{contact.Key} -> {contact.Value}");
                        }
                        break;
                }

            }
        }
    }
}
