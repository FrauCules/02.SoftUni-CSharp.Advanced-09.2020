using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer // 100%
{
    public class Program
    {
        static List<Trainer> trainers;

        static void Main(string[] args)
        {
            int count = 0;
            int pokemonsCount = 0;
            string line;

            trainers = new List<Trainer>();
            while ((line = Console.ReadLine().Trim()) != "Tournament")
            {
                string[] input = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                // string name, string PokemonName, string PokemonElement, int PokemonHealth
                string name = input[0];
                string PokemonName = input[1];
                string PokemonElement = input[2];
                int PokemonHealth = int.Parse(input[3]);
                Trainer trainer;
                if ((trainer = GetTrainer(name)) == null)
                {
                    trainer = new Trainer(name, PokemonName, PokemonElement, PokemonHealth);
                    trainers.Add(trainer);
                }
                else
                    trainer.AddPokemon(PokemonName, PokemonElement, PokemonHealth);
            }
            
            while ((line = Console.ReadLine().Trim()) != "End")
            {
                foreach (var currentTrainer in trainers)
                {
                    foreach (var pokemon in currentTrainer.PokemonList)
                    {
                        if (pokemon.Element == line && pokemon.Health > 0)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                        currentTrainer.Badges++;
                    else
                    {
                        foreach (var pokemon in currentTrainer.PokemonList)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                    count = 0;
                }
            }

            foreach (var currentTrainer in trainers.OrderByDescending(x => x.Badges))
            {
                foreach (var pokemon in currentTrainer.PokemonList)
                {
                    if (pokemon.Health > 0)
                    {
                        pokemonsCount++;
                    }
                }
                Console.WriteLine($"{currentTrainer.name} {currentTrainer.Badges} {pokemonsCount}");
                pokemonsCount = 0;
            }
        }

        static Trainer GetTrainer(string name)
            => trainers.FirstOrDefault(x => x.name == name);
    }
}
