using System.Reflection.Metadata.Ecma335;

namespace supertrumfo.dominio
{
    class Pokemon
    {
        public string pokemonName { get; set; }
        public PokemonType Type { get; set; }
        public int pokemonAttack { get; set; }
        public int pokemonDefense { get; set; }
        public int pokemonSpeed { get; set; }
        public int pokemonSpecialAttack { get; set; }
        public int pokemonSpecialDefense { get; set; }

        public Pokemon(string name,PokemonType type, int attack, 
        int defense, int speed, int specialAttack, int specialDefense)
        {
            pokemonName = name;
            Type = type;
            pokemonAttack = attack;
            pokemonDefense = defense;
            pokemonSpeed = speed;
            pokemonSpecialAttack = specialAttack;
            pokemonSpecialDefense = specialDefense;
        }

        public override string ToString()
        {
            return  $"Nome: {pokemonName}\n" +
                    $"Tipo {Type}\n" +
                    $"Ataque {pokemonAttack}\n" +
                    $"Velocidade {pokemonDefense}\n" +
                    $"Ataque Especial {pokemonSpecialAttack}\n" +
                    $"Defesa Especial {pokemonSpecialDefense}\n";
        }

        public int GetStat(StatsPokemon stat)
        {
            return stat switch
            {
                StatsPokemon.pokemonAttack => pokemonAttack,
                StatsPokemon.pokemonDefense => pokemonDefense,
                StatsPokemon.pokemonSpeed => pokemonSpeed,
                StatsPokemon.pokemonSpecialAttack => pokemonSpecialAttack,
                StatsPokemon.pokemonSpecialDefense => pokemonSpecialDefense,
                _ => throw new Exception("Status invalido")
            };
        }
    }
}