using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => this.roster.Count;

        public void AddPlayer(Player player)
        {
            if (roster.Count < this.Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            int count = 0;
            foreach (var item in roster)
            {
                if(item.Name== name)
                {
                    count++;
                }
            }
            if(count==0)
            {
                return false;
            }
            
            roster = roster.Where(x => x.Name != name).ToList();
            return true;
        }

        public void PromotePlayer(string name)
        {
            var nameMember =
                this.roster
                    .Where(x => x.Name == name)
                    .First();
            if (nameMember.Rank != "Member")
            {
                nameMember.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            var nameMember =
                this.roster
                    .Where(x => x.Name == name)
                    .First();
            if (nameMember.Rank != "Trial")
            {
                nameMember.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string species)
        {
            var kik = roster.Where(x => x.Class == species).ToArray();
            foreach (var item in kik)
            {
                roster.Remove(item);
            }

            return kik;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var item in roster)
            {
                sb.AppendLine(item.ToString());
            }
            
            return sb.ToString().Trim();
        }
    }
}
