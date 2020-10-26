using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public string name;
        
        public Trainer(string name, string PokemonName, string PokemonElement, int PokemonHealth)
        {
            this.name = name; // трябва да е с this.name (this.Name - дава грешка)
            Badges = 0;
            PokemonList = new List<Pokemon>();
            AddPokemon(PokemonName, PokemonElement, PokemonHealth);
        }
        
        public int Badges { get; set; }
        public List<Pokemon> PokemonList { get; set; }

        public void AddPokemon(string name, string element, int health)
        {
            Pokemon pokemon = new Pokemon(name, element, health);
            PokemonList.Add(pokemon);
        }
    }
}
