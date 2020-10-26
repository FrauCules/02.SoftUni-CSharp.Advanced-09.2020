using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer // 100%
{
    class Program
    {
        static List<Trainer> trainers;

        static void Main(string[] args)
        {
            int count = 0;
            int pokemonsCount = 0;

            trainers = new List<Trainer>();
            string input = Console.ReadLine();
            while (input != "Tournament")
            {
                string[] trainerInfo = input.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Trainer trainer;
                if ((trainer = ContainTrainer(trainerInfo[0])) == null)
                {
                    trainer = new Trainer(trainerInfo[0], trainerInfo[1], trainerInfo[2], int.Parse(trainerInfo[3]));
                    trainers.Add(trainer);
                }
                else
                    trainer.AddPokemon(trainerInfo[1], trainerInfo[2], int.Parse(trainerInfo[3]));
                input = Console.ReadLine();
            }
            string elementInput = Console.ReadLine().Trim();
            while (elementInput != "End")
            {
                foreach (var currentTrainer in trainers)
                {
                    foreach (var pokemon in currentTrainer.pokemonList)
                    {
                        if (pokemon.element == elementInput && pokemon.health > 0)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                        currentTrainer.badges++;
                    else
                    {
                        foreach (var pokemon in currentTrainer.pokemonList)
                        {
                            pokemon.health -= 10;
                        }
                    }
                    count = 0;
                }

                elementInput = Console.ReadLine().Trim();
            }

            foreach (var currentTrainer in trainers.OrderByDescending(x => x.badges))
            {
                foreach (var pokemon in currentTrainer.pokemonList)
                {
                    if (pokemon.health > 0)
                    {
                        pokemonsCount++;
                    }
                }
                Console.WriteLine($"{currentTrainer.name} {currentTrainer.badges} {pokemonsCount}");
                pokemonsCount = 0;
            }
        }


        static Trainer ContainTrainer(string name)
        {
            foreach (var item in trainers)
            {
                if (item.name == name)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
