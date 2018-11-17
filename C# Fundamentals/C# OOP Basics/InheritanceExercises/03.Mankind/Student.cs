using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03.Mankind
{
    public class Student : Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => facultyNumber;
            set
            {
                if (value.Length < 5 ||  value.Length > 10 || !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

              sb.AppendLine($"First Name: {this.FirstName}")
                .AppendLine($"Last Name: {this.LastName}")
                .Append($"Faculty number: {this.FacultyNumber}");

            return sb.ToString();
        }
    }
}
