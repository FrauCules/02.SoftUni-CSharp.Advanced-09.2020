using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    class Trainer
    {

        public string name;
        public int badges;
        public List<Pokemon> pokemonList;

        public Trainer(string name, string PokemonName, string PokemonElement, int PokemonHealth)
        {
            this.name = name;
            this.badges = 0;
            pokemonList = new List<Pokemon>();
            AddPokemon(PokemonName, PokemonElement, PokemonHealth);
        }
        public void AddPokemon(string name, string element, int health)
        {
            Pokemon pokemon = new Pokemon(name, element, health);
            pokemonList.Add(pokemon);
        }

    }
}
