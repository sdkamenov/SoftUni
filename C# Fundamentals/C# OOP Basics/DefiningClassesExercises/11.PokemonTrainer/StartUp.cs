using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Tournament")
                {
                    break;
                }

                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHP = int.Parse(input[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHP);
                if (trainers.ContainsKey(trainerName) == false)
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }
                trainers[trainerName].Pokemons.Add(pokemon);

            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                foreach (Trainer trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Any(p => p.Element == input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                }
                foreach (Trainer trainer in trainers.Values)
                {
                    for (int i = 0; i < trainer.Pokemons.Count; i++)
                    {
                        if (trainer.Pokemons[i].Health <= 0)
                        {
                            trainer.Pokemons.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            foreach (var trainer in trainers.Values.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine(trainer);
            }
        }
    }
}
