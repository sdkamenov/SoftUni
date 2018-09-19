using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StudentGroups
{
    class StudentGroups
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            Town currentTown = null;

            List<Student> students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    LastTown(currentTown, students, towns);
                    break;
                }
                if (input.Contains("=>"))
                {
                    int separatorIndex = input.IndexOf('=');
                    string name = input.Substring(0, separatorIndex - 1);
                    int capacity = int.Parse(input.Substring(separatorIndex + 3).Split()[0]);

                    if (currentTown != null)
                    {
                        LastTown(currentTown, students, towns);
                    }
                    students.Clear();
                    currentTown = new Town(name, capacity);
                    continue;
                }

                var split = input
                    .Split('|')
                    .Select(s => s.Trim())
                    .ToArray();
                students.Add(new Student(split[0], split[1], split[2]));
            }

            int groupsCount = towns.Sum(t => t.Groups.Count);
            Console.WriteLine($"Created {groupsCount} groups in {towns.Count} towns:");
            foreach (var town in towns.OrderBy(t => t.Name))
            {
                foreach (var group in town.Groups)
                {
                    Console.WriteLine(town.Name + " => " +
                        string.Join(", ", group.Select(s => s.Email)));
                }
            }
        }

        private static void LastTown(Town currentTown, List<Student> students, List<Town> towns)
        {
            int oldSeats = currentTown.SeatsCount;
            for (int i = 0; i < (double)students.Count / currentTown.SeatsCount; i++)
            {
                students = students
                    .OrderBy(s => s.RegistrationDate)
                    .ThenBy(s => s.Name)
                    .ThenBy(s => s.Email)
                    .ToList();
                currentTown.Groups.Add(students.Skip(i * oldSeats).Take(oldSeats).ToArray());
            }
            towns.Add(currentTown);
        }
    }

    class Student
    {
        public Student(string name, string email, string registrationDate)
        {
            Name = name;
            Email = email;
            RegistrationDate = DateTime.ParseExact(registrationDate, "d-MMM-yyyy", CultureInfo.InvariantCulture);
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public Town(string name, int seatsCount)
        {
            Name = name;
            SeatsCount = seatsCount;
            Groups = new List<Student[]>();
        }

        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student[]> Groups { get; set; }
    }
}
