using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    class Clinic
    {
        private List<Pet> pets;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            this.pets = new List<Pet>();
        }

        public int Capacity { get; set; }

        public int Count
            => this.pets.Count; // връща броя на клетките

        public void Add(Pet pet)
        {
            if (Count < Capacity)
            {
                pets.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            bool exists = pets.Any(x => x.Name == name);
            if (exists)
            {
                pets = pets.Where(x => x.Name != name).ToList();
                return true;
            }    
            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            bool exists = pets.Any(x => x.Name == name && x.Owner == owner);
            if (exists)
            {
                var getPet = pets.Where(x => x.Name == name && x.Owner == owner).First();
                return getPet;
            }
            else
            {
                return null; 
            }
        }

        public Pet GetOldestPet()
        {
            var oldestPet = pets.OrderByDescending(x => x.Age).First();
            return oldestPet;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");
            foreach (var item in pets)
            {
                sb.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
            }

            return sb.ToString().Trim();
        }
    }
}
