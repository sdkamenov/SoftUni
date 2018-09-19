using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MentorGroup
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of dates")
                {
                    break;
                }

                string[] groupActivities = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string userName = groupActivities[0];
                List<DateTime> dates = groupActivities
                    .Skip(1)
                    .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    .ToList();

                if (users.Any(x => x.Name == userName))
                {
                    User existingUser = users
                        .Where(x => x.Name == userName)
                        .First();
                    existingUser.DatesActivities.AddRange(dates);
                }
                else
                {
                    User user = new User(userName, new List<string>(), dates);
                    users.Add(user);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of comments")
                {
                    break;
                }

                string[] userComment = input.Split('-');
                string userName = userComment[0];
                string comment = userComment[1];

                if (users.Any(x => x.Name == userName))
                {
                    User existingUser = users
                        .Where(x => x.Name == userName)
                        .First();
                    existingUser.Comments.Add(comment);
                }

            }

            users = users.OrderBy(x => x.Name).ToList();
            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in user.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in user.DatesActivities.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }


        }
    }

    class User
    {
        public User(string name, List<string> comments, List<DateTime> datesActivities)
        {
            Name = name;
            Comments = comments;
            DatesActivities = datesActivities;
        }

        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> DatesActivities { get; set; }
    }
}
