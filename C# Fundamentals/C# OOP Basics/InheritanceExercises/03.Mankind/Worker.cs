using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Mankind
{
    public class Worker : Human
    {
        private const int WorkingDays = 5;
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get => weekSalary;
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }
        public decimal WorkHoursPerDay
        {
            get => workHoursPerDay;
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                workHoursPerDay = value;
            }
        }

        private decimal SalaryPerHour()
        {
            decimal salaryPerHour = (this.WeekSalary / WorkingDays) / this.WorkHoursPerDay;
            return salaryPerHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"First Name: {this.FirstName}")
              .AppendLine($"Last Name: {this.LastName}")
              .AppendLine($"Week Salary: {this.WeekSalary:f2}")
              .AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}")
              .Append($"Salary per hour: {this.SalaryPerHour():f2}");

            return sb.ToString();
        }
    }
}
