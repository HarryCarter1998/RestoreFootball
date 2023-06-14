﻿
using System.Text.Json.Serialization;

namespace RestoreFootball.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Rating { get; set; } = 5;
        public bool SignedUp { get; set; } = false;
        public Team Team { get; set; } = 0;

        [JsonIgnore]
        public virtual ICollection<GameweekPlayer>? GameweekPlayers { get; set; } = new List<GameweekPlayer>();
    }

    public enum Team { Green, NonBibs, Yellow, Orange }
}
