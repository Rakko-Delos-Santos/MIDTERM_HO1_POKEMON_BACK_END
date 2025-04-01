﻿using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PokemonDataService
    {
        private readonly List<Pokemon> _pokemons;

        public PokemonDataService()
        {
            _pokemons = GeneratePokemonData();
        }

        public List<Pokemon> GetAllPokemons() => _pokemons;

        public Pokemon GetPokemonById(int id) => _pokemons.FirstOrDefault(p => p.Id == id);

        public List<Pokemon> GetPokemonsByGeneration(int generation) =>
            _pokemons.Where(p => p.Generation == generation).ToList();

        public List<Pokemon> GetPaginatedPokemons(int page, int pageSize) =>
            _pokemons.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        private List<Pokemon> GeneratePokemonData()
        {
            return new List<Pokemon>
            {
                // Generation 1 - Bulbasaur Line
                new Pokemon {
                    Id = 1, Name = "Bulbasaur", Types = new List<string> { "Grass", "Poison" },
                    Generation = 1, NextEvolutionId = 2, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/bulbasaur.jpg",
                    Height = 7, Weight = 69
                },
                new Pokemon {
                    Id = 2, Name = "Ivysaur", Types = new List<string> { "Grass", "Poison" },
                    Generation = 1, NextEvolutionId = 3, BaseEvolutionId = 1,
                    ImageUrl = "https://img.pokemondb.net/artwork/ivysaur.jpg",
                    Height = 10, Weight = 130
                },
                new Pokemon {
                    Id = 3, Name = "Venusaur", Types = new List<string> { "Grass", "Poison" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 1,
                    ImageUrl = "https://img.pokemondb.net/artwork/venusaur.jpg",
                    Height = 20, Weight = 1000
                },

                // Generation 1 - Charmander Line
                new Pokemon {
                    Id = 4, Name = "Charmander", Types = new List<string> { "Fire" },
                    Generation = 1, NextEvolutionId = 5, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/charmander.jpg",
                    Height = 6, Weight = 85
                },
                new Pokemon {
                    Id = 5, Name = "Charmeleon", Types = new List<string> { "Fire" },
                    Generation = 1, NextEvolutionId = 6, BaseEvolutionId = 4,
                    ImageUrl = "https://img.pokemondb.net/artwork/charmeleon.jpg",
                    Height = 11, Weight = 190
                },
                new Pokemon {
                    Id = 6, Name = "Charizard", Types = new List<string> { "Fire", "Flying" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 4,
                    ImageUrl = "https://img.pokemondb.net/artwork/charizard.jpg",
                    Height = 17, Weight = 905
                },

                // Generation 1 - Squirtle Line
                new Pokemon {
                    Id = 7, Name = "Squirtle", Types = new List<string> { "Water" },
                    Generation = 1, NextEvolutionId = 8, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/squirtle.jpg",
                    Height = 5, Weight = 90
                },
                new Pokemon {
                    Id = 8, Name = "Wartortle", Types = new List<string> { "Water" },
                    Generation = 1, NextEvolutionId = 9, BaseEvolutionId = 7,
                    ImageUrl = "https://img.pokemondb.net/artwork/wartortle.jpg",
                    Height = 10, Weight = 225
                },
                new Pokemon {
                    Id = 9, Name = "Blastoise", Types = new List<string> { "Water" },
                    Generation = 1, NextEvolutionId = null, BaseEvolutionId = 7,
                    ImageUrl = "https://img.pokemondb.net/artwork/blastoise.jpg",
                    Height = 16, Weight = 855
                },

                // Generation 2 - Chikorita Line
                new Pokemon {
                    Id = 152, Name = "Chikorita", Types = new List<string> { "Grass" },
                    Generation = 2, NextEvolutionId = 153, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/chikorita.jpg",
                    Height = 9, Weight = 64
                },
                new Pokemon {
                    Id = 153, Name = "Bayleef", Types = new List<string> { "Grass" },
                    Generation = 2, NextEvolutionId = 154, BaseEvolutionId = 152,
                    ImageUrl = "https://img.pokemondb.net/artwork/bayleef.jpg",
                    Height = 12, Weight = 158
                },
                new Pokemon {
                    Id = 154, Name = "Meganium", Types = new List<string> { "Grass" },
                    Generation = 2, NextEvolutionId = null, BaseEvolutionId = 152,
                    ImageUrl = "https://img.pokemondb.net/artwork/meganium.jpg",
                    Height = 18, Weight = 1005
                },

                // Add more Generation 1 and 2 Pokémon below...
                // Continue the pattern for at least 100 Pokémon
                // Make sure to include all required properties:
                // - Id, Name, Types, Generation
                // - NextEvolutionId, BaseEvolutionId (nullable)
                // - ImageUrl, Height, Weight
            };
        }
    }
}