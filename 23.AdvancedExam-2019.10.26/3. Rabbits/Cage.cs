using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> rabbits;
        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.rabbits = new List<Rabbit>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        
        public int Count => this.rabbits.Count;

        public void Add(Rabbit rabbit)
        {
            if (rabbits.Count < this.Capacity)
            {
                rabbits.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            rabbits = rabbits.Where(x => x.Name != name).Select(y => y).ToList();
            if(rabbits== null)
            {
                return false;
            }

            return true;
        }

        public void RemoveSpecies(string species)
        {
            rabbits = rabbits.Where(x => x.Species != species).ToList();
        }

        // SellRabbit
        public Rabbit SellRabbit(string name)
        {
            var sellRabit =
                this.rabbits
                    .Where(x => x.Name == name)
                    .First();
            if(sellRabit!= null)
            {
                sellRabit.Available = false;
                return sellRabit;
            }
            return null;
        }

        // SellRabbitsBySpecies
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var soldRabbits = rabbits.Where(x => x.Species == species).ToArray();
            foreach (var item in soldRabbits)
            {
                item.Available = false;
            }

            return soldRabbits;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {Name}:");
            if (this.rabbits.Count >= 0)
            {
                foreach (var item in this.rabbits.Where(x=>x.Available==true))
                {
                    sb.AppendLine($"{item}");
                }
            }

            return sb.ToString().Trim();
        }
    }
}
