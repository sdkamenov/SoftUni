﻿using _08.MilitaryElite.Contracts;
using _08.MilitaryElite.Enums;
using System.Collections.Generic;

namespace _08.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<IMission>();
        }

        public ICollection<IMission> Missions { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nCorps: {Corps}\nMissions:{(Missions.Count == 0 ? "" : "\n  ")}{string.Join("\n  ", Missions)}";
        }
    }
}
