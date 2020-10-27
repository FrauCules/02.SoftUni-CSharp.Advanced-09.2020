using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroList;

        public HeroRepository()
        {
            this.heroList = new List<Hero>();
        }

        public int Count => this.heroList.Count;

        public void Add(Hero hero)
        {
            heroList.Add(hero);
        }

        public void Remove(string name)
        {
            heroList = heroList.Where(x => x.Name != name).Select(y => y).ToList();
        }

        public Hero GetHeroWithHighestStrength()
        {
            var highestStrength =
                this.heroList
                    .OrderByDescending(x => x.Item.Strength)
                    .First();

            return highestStrength;
        }

        public Hero GetHeroWithHighestAbility()
        {
            var highestAbility =
                this.heroList
                    .OrderByDescending(x => x.Item.Ability)
                    .First();

            return highestAbility;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            var highestIntelligence =
                this.heroList
                    .OrderByDescending(x => x.Item.Intelligence)
                    .First();

            return highestIntelligence;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.heroList.Count >= 0)
            {
                foreach (var hero in this.heroList)
                {
                    sb.AppendLine($"{hero}");
                }
            }

            return sb.ToString();
        }
    }
}
