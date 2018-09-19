using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split();
                string name = tokens[0];

                //List<double> grades = new List<double>();
                //for (int j = 1; j < tokens.Length; j++)
                //{
                //    grades.Add(double.Parse(tokens[j]));
                //}

                double[] grades = tokens.Skip(1).Select(double.Parse).ToArray();

                Student student = new Student(name, grades);
                students.Add(student);
            }

            List<Student> filtered = students
                .Where(x => x.Grades.Average() >= 5.00)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Grades.Average())
                .ToList();

            foreach (var student in filtered)
            {
                Console.WriteLine($"{student.Name} -> {student.Grades.Average():f2}");
            }
        }
    }

    class Student
    {
        public Student(string name, double[] grades)
        {
            Name = name;
            Grades = grades;
        }

        public string Name { get; set; }
        public double[] Grades { get; set; }
    }
}
