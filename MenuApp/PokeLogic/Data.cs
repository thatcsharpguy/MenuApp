using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuApp.Controls;

namespace MenuApp.PokeLogic
{
    public class Data
    {
        public static List<string> PokemonTypes = new List<string>
        {
            "Normal", "Fight", "Flying",
            "Poison","Ground", "Rock",
            "Bug", "Ghost", "Fire",
            "Water","Grass","Electric",
            "Psychic","Ice","Dragon"
        };

        public static List<Gym> Gyms = new List<Gym>
        {
            new Gym
            {
                City ="Pewter City",
                Type = "Rock"
            },
            new Gym
            {
                City ="Cerulean City",
                Type = "Water"
            },
            new Gym
            {
                City ="Vermilion City",
                Type = "Electric"
            },
            new Gym
            {
                City ="Celadon City",
                Type = "Grass"
            },
            new Gym
            {
                City ="Fuchsia City",
                Type = "Poison"
            },
            new Gym
            {
                City ="Cinnabar & Seafoam Islands",
                Type = "Grass"
            },
            new Gym
            {
                City ="Viridian",
                Type = "Ground"
            }
        };

        public static List<Trainer> EliteTrainers = new List<Trainer>
        {
            new Trainer
            {
                Name = "Lorelei",
                PokemonTypes = "Ice",
                Pokemon = new List<Pokemon>
                {
                    new Pokemon
                    {
                        Attacks = new List<string> {"Growl","Aurora beam", "Rest", "Take down"},
                        Type = "Water / Ice",
                        Level = 54,
                        Name = "Dewgong"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Supersonic","Clamp", "Aurora Beam", "Spike Cannon"},
                        Type = "Water / Ice",
                        Level = 53,
                        Name = "Cloyster"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Growl","Watergun", "Withdraw", "Amnesia"},
                        Type = "Water / Psychic",
                        Level = 54,
                        Name = "Slowbro"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"DoubleSlap","Ice Punch", "Body Slam", "Thrash"},
                        Type = "Ice / Psychic",
                        Level = 56,
                        Name = "Jynx"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Blizzard","Hydro pump", "Body slam", "Confuse Ray"},
                        Type = "Water / Ice",
                        Level = 56,
                        Name = "Lapras"
                    }
                }
            },
            new Trainer
            {
                Name = "Bruno",
                PokemonTypes = "Fighting",
                Pokemon = new List<Pokemon>
                {
                    new Pokemon
                    {
                        Attacks = new List<string> { "Rock Throw", "Rage", "Slam", "Harden"},
                        Type = "Rock / Ground",
                        Level = 53,
                        Name = "Onix"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Ice Punch","Mega Punch", "Thunder Punch", "Counter"},
                        Type = "Fighting",
                        Level = 55,
                        Name = "Hitmonchan"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Jump Kick","Hi Jump Kick", "Mega Kick", "Focus Energy"},
                        Type = "Fighting",
                        Level = 55,
                        Name = "Hitmonlee"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> { "Rock Throw", "Rage", "Slam", "Harden"},
                        Type = "Rock / Ground",
                        Level = 56,
                        Name = "Onix"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Leer","Focus Energy", "Fissure", "Submission"},
                        Type = "Fighting",
                        Level = 58,
                        Name = "Machamp"
                    }
                }
            },
            new Trainer
            {
                Name = "Agatha",
                PokemonTypes = "Ghost",
                Pokemon = new List<Pokemon>
                {
                    // TODO: Fix attacks
                    new Pokemon
                    {
                        Attacks = new List<string> { "Rock Throw", "Rage", "Slam", "Harden"},
                        Type = "Ghost / Poison",
                        Level = 56,
                        Name = "Gengar"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Ice Punch","Mega Punch", "Thunder Punch", "Counter"},
                        Type = "Poison / Flying",
                        Level = 56,
                        Name = "Golbat"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Jump Kick","Hi Jump Kick", "Mega Kick", "Focus Energy"},
                        Type = "Ghost / Poison",
                        Level = 55,
                        Name = "Haunter"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> { "Rock Throw", "Rage", "Slam", "Harden"},
                        Type = "Poison",
                        Level = 58,
                        Name = "Arbok"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Leer","Focus Energy", "Fissure", "Submission"},
                        Type = "Ghost / Poison",
                        Level = 60,
                        Name = "Gengar"
                    }
                }
            },
            new Trainer
            {
                Name = "Lance",
                PokemonTypes = "Dragon",
                Pokemon = new List<Pokemon>
                {
                    // TODO: Fix pokemons
                    new Pokemon
                    {
                        Attacks = new List<string> { "Rock Throw", "Rage", "Slam", "Harden"},
                        Type = "Ghost / Poison",
                        Level = 56,
                        Name = "Gengar"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Ice Punch","Mega Punch", "Thunder Punch", "Counter"},
                        Type = "Poison / Flying",
                        Level = 56,
                        Name = "Golbat"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Jump Kick","Hi Jump Kick", "Mega Kick", "Focus Energy"},
                        Type = "Ghost / Poison",
                        Level = 55,
                        Name = "Haunter"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> { "Rock Throw", "Rage", "Slam", "Harden"},
                        Type = "Poison",
                        Level = 58,
                        Name = "Arbok"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Leer","Focus Energy", "Fissure", "Submission"},
                        Type = "Ghost / Poison",
                        Level = 60,
                        Name = "Gengar"
                    }
                }
            },
            new Trainer
            {
                Name = "Blue",
                PokemonTypes = "Various",
                Pokemon = new List<Pokemon>
                {
                    // TODO: Fix pokemons
                    new Pokemon
                    {
                        Attacks = new List<string> { "Rock Throw", "Rage", "Slam", "Harden"},
                        Type = "Ghost / Poison",
                        Level = 56,
                        Name = "Gengar"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Ice Punch","Mega Punch", "Thunder Punch", "Counter"},
                        Type = "Poison / Flying",
                        Level = 56,
                        Name = "Golbat"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Jump Kick","Hi Jump Kick", "Mega Kick", "Focus Energy"},
                        Type = "Ghost / Poison",
                        Level = 55,
                        Name = "Haunter"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> { "Rock Throw", "Rage", "Slam", "Harden"},
                        Type = "Poison",
                        Level = 58,
                        Name = "Arbok"
                    },
                    new Pokemon
                    {
                        Attacks = new List<string> {"Leer","Focus Energy", "Fissure", "Submission"},
                        Type = "Ghost / Poison",
                        Level = 60,
                        Name = "Gengar"
                    }
                }
            }
        };
    }

    public class Gym
    {
        public string City { get; set; }
        public string Type { get; set; }
    }

    public class Trainer
    {
        public string Name { get; set; }
        public string PokemonTypes { get; set; }
        public List<Pokemon> Pokemon { get; set; }
    }

    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public List<string> Attacks { get; set; }
    }
}
