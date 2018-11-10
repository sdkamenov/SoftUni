using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FootballTeamGenerator
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];


                if (command == "END")
                {
                    break;
                }

                try
                {
                    if (command == "Team")
                    {
                        string teamName = input[1];
                        teams.Add(teamName, new Team(teamName));
                    }
                    else if (command == "Add")
                    {
                        string teamName = input[1];
                        if (teams.ContainsKey(teamName) == false)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        string playerName = input[2];
                        int endurance = int.Parse(input[3]);
                        int sprint = int.Parse(input[4]);
                        int dribble = int.Parse(input[5]);
                        int passing = int.Parse(input[6]);
                        int shooting = int.Parse(input[7]);
                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        teams[teamName].AddPlayer(player);
                    }
                    else if (command == "Remove")
                    {
                        string teamName = input[1];
                        string playerName = input[2];
                        teams[teamName].RemovePlayer(playerName);
                    }
                    else if (command == "Rating")
                    {
                        string teamName = input[1];
                        if (teams.ContainsKey(teamName) == false)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");

                        }
                        Console.WriteLine(teams[teamName].ToString());
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}
