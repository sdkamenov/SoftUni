using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string name = tokens[0];
                decimal salary = decimal.Parse(tokens[1]);
                string position = tokens[2];
                string department = tokens[3];
                Employee employee = new Employee(name, salary, position, department);

                if (tokens.Length == 5)
                {
                    if (tokens[4].Contains("@"))
                    {
                        employee.Email = tokens[4];
                    }
                    else
                    {
                        int age = int.Parse(tokens[4]);
                        employee.Age = age;
                    }
                }
                else if (tokens.Length == 6)
                {
                    int age = int.Parse(tokens[5]);
                    employee.Email = tokens[4];
                    employee.Age = age;
                }

                employees.Add(employee);
            }

            var topDepartment = employees
                .GroupBy(x => x.Department)
                .ToDictionary(x => x.Key, y => y.Select(s => s))
                .OrderByDescending(x=> x.Value.Average(s=> s.Salary))
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");
            foreach (Employee employee in topDepartment.Value.OrderByDescending(s=>s.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
