using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split('-');

                string creatorName = tokens[0];
                string teamName = tokens[1];

                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(x => x.OwnerName == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creatorName);
                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }

                string[] tokens = input.Split("->").ToArray();
                string memberName = tokens[0];
                string teamName = tokens[1];

                if (teams.Any(x => x.TeamName == teamName) == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(x => x.TeamMates.Contains(memberName)) || teams.Any(x => x.OwnerName == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                Team team = teams
                    .FirstOrDefault(x => x.TeamName == teamName);

                team.TeamMates.Add(memberName);
            }

            List<Team> ordered = teams
                .Where(x => x.TeamMates.Count > 0)
                .OrderByDescending(x => x.TeamMates.Count)
                .ThenBy(x => x.TeamName)
                .ToList();
            foreach (var team in ordered)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.OwnerName}");

                foreach (var member in team.TeamMates.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            List<Team> disbanded = teams
                .Where(x => x.TeamMates.Count == 0).ToList();

            Console.WriteLine("Teams to disband:");
            foreach (var team in disbanded.OrderBy(x=>x.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    class Team
    {
        public Team(string teamName, string ownerName)
        {
            TeamName = teamName;
            OwnerName = ownerName;
            TeamMates = new List<string>();
        }

        public string TeamName { get; set; }
        public string OwnerName { get; set; }
        public List<string> TeamMates { get; set; }
    }
}
