using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    class Bag
    {
        private List<Present> presents;
        public Bag(string color, int capacity)
        {
            Color = color;
            Capacity = capacity;
            this.presents = new List<Present>();
        }

        public string Color { get; set; }
        public int Capacity { get; set; }

        public int Count => this.presents.Count;

        public void Add(Present present)
        {
            if (presents.Count < this.Capacity)
            {
                presents.Add(present);
            }
        }

        public bool Remove(string name)
        {
            presents = presents.Where(x => x.Name != name).Select(y => y).ToList();
            if (presents == null)
            {
                return false;
            }

            return true;
        }

        public Present GetHeaviestPresent()
        {
            var heaviestPresent =
                this.presents
                    .OrderByDescending(x => x.Weight)
                    .First();

            return heaviestPresent;
        }

        public Present GetPresent(string name)
        {
            var namePresent =
                this.presents
                    .Where(x => x.Name == name)
                    .First();

            return namePresent;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} bag contains:");
            if (this.presents.Count >= 0)
            {
                foreach (var item in this.presents)
                {
                    sb.AppendLine($"{item}");
                }
            }

            return sb.ToString().Trim();
        }
    }
}
