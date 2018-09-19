using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;

namespace Problem02
{
    class Problem02
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "course start")
                {
                    break;
                }

                string[] tokens = input.Split(":");
                string command = tokens[0];
                string titleLesson = tokens[1];

                //if (tokens.Length == 3)
                //{
                //    string swapOrIndex = tokens[2];
                //}
                if (command == "Add" && (lessons.Contains(titleLesson) == false))
                {
                    lessons.Add(titleLesson);
                }
                if (command == "Insert" && (lessons.Contains(titleLesson) == false))
                {
                    int index = int.Parse(tokens[2]);
                    if (index < lessons.Count)
                    {
                        lessons.Insert(index, titleLesson);
                    }
                }
                if (command == "Remove" && lessons.Contains(titleLesson))
                {
                    lessons.Remove(titleLesson);
                    if (lessons.Contains($"{titleLesson}-Exercise"))
                    {
                        lessons.Remove($"{titleLesson}-Exercise");
                    }
                }
                if (command == "Swap" && lessons.Contains(titleLesson) && lessons.Contains(tokens[2]))
                {
                    int index1 = lessons.IndexOf(titleLesson);
                    int index2 = lessons.IndexOf(tokens[2]);
                    string firstItem = titleLesson;
                    string secondItem = tokens[2];
                    lessons.Insert(index1, secondItem);
                    lessons.RemoveAt(index1 + 1);
                    lessons.Insert(index2, firstItem);
                    lessons.RemoveAt(index2 + 1);
                }
                if (command == "Exercise")
                {
                    if (lessons.Contains(titleLesson))
                    {
                        lessons.Insert(lessons.IndexOf(titleLesson) + 1, $"{titleLesson}-Exercise");
                    }
                    else
                    {
                        lessons.Add(titleLesson);
                        lessons.Add($"{titleLesson}-Exercise");
                    }


                }

            }
            foreach (var lesson in lessons)
            {
                Console.WriteLine($"{lessons.IndexOf(lesson) + 1}.{lesson}");
            }
        }
    }
}
