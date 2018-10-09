using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var students = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(":");
                if (input[0] == "end of contests")
                {
                    break;
                }

                string contestName = input[0];
                string password = input[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, password);
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split("=>");
                if (input[0] == "end of submissions")
                {
                    break;
                }


                string contestName = input[0];
                string contestPassword = input[1];
                string username = input[2];
                int points = int.Parse(input[3]);

                if (contests.ContainsKey(contestName) && contests[contestName] == contestPassword)
                {
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, new Dictionary<string, int>());
                    }

                    if (!students[username].ContainsKey(contestName))
                    {
                        students[username].Add(contestName, points);
                    }

                    if (students[username][contestName] < points)
                    {
                        students[username][contestName] = points;
                    }
                }
            }


            var topStudent = students.OrderByDescending(x => x.Value.Sum(s => s.Value)).FirstOrDefault();

            Console.WriteLine($"Best candidate is {topStudent.Key} with total {topStudent.Value.Sum(x => x.Value)} points.");
            Console.WriteLine("Ranking:");

            var sortedStudents = students.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.Key);

                foreach (var contest in student.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
