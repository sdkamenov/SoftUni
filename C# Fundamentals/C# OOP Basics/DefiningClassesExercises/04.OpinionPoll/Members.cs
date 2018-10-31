using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Members
    {
        private List<Person> people;

        public Members()
        {
            this.people = new List<Person>();
        }

        public List<Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }
    }
}
