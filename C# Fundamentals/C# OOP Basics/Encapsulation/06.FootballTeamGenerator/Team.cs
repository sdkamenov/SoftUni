using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private Dictionary<string, Player> players;

        public Team(string name)
        {
            Name = name;
            players = new Dictionary<string, Player>();
        }

        public int Rating
        {
            get { return this.CalculateRating(); }
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            if (this.players.ContainsKey(player.Name) == false)
            {
                this.players[player.Name] = player;
            }
        }

        public void RemovePlayer(string player)
        {
            if (this.players.ContainsKey(player) == false)
            {
                throw new ArgumentException($"Player {player} is not in {this.Name} team.");
            }
            else
            {
                this.players.Remove(player);
            }
        }

        private int CalculateRating()
        {
            if (this.players.Count != 0)
            {
                return (int)this.players.Average(r => r.Value.Rating);
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
