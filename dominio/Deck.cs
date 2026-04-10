namespace supertrumfo.dominio
{
    public class Deck{
        public List<Pokemon> getAllCards(){ //V
            return new List<Pokemon> //V
                {
                    new Pokemon("Pikachu", PokemonType.Eletrico, 55, 40, 90, 50, 50),
                    new Pokemon("Greninja", PokemonType.Agua, 95, 67, 122, 103, 71),
                    new Pokemon("Swampert", PokemonType.Agua, 110, 90, 60, 85, 90),
                    new Pokemon("Talonflame", PokemonType.Fogo, 81, 71, 126, 74, 69),
                    new Pokemon("Charizard", PokemonType.Fogo, 84, 78, 100, 109, 85),
                    new Pokemon("Torterra", PokemonType.Grama, 109, 105, 56, 75, 85),
                    new Pokemon("Sceptile", PokemonType.Grama, 85, 65, 120, 105, 85),
                    new Pokemon("Magnemite", PokemonType.Eletrico, 35, 70, 45, 95, 55),
                    new Pokemon("Luxray", PokemonType.Eletrico, 120, 79, 70, 95, 79),
                    new Pokemon("Garchomp", PokemonType.Rocha, 130, 95, 102, 80, 85),
                    new Pokemon("Krookodile", PokemonType.Rocha, 117, 80, 92, 65, 70),
                    new Pokemon("Vaporeon", PokemonType.Agua, 65, 60, 65, 110, 95),
                    new Pokemon("Gyarados", PokemonType.Agua, 125, 79, 81, 60, 100),
                    new Pokemon("Lapras", PokemonType.Agua, 85, 80, 60, 85, 95),
                    new Pokemon("Starmie", PokemonType.Agua, 75, 85, 115, 100, 85),
                    new Pokemon("Arcanine", PokemonType.Fogo, 110, 80, 95, 100, 80),
                    new Pokemon("Magmar", PokemonType.Fogo, 95, 57, 93, 100, 85),
                    new Pokemon("Flareon", PokemonType.Fogo, 130, 60, 65, 95, 110),
                    new Pokemon("Houndoom", PokemonType.Fogo, 90, 50, 95, 110, 80),
                    new Pokemon("Meganium", PokemonType.Grama, 82, 100, 80, 83, 100),
                    new Pokemon("Bellossom", PokemonType.Grama, 80, 95, 50, 90, 100),
                    new Pokemon("Roserade", PokemonType.Grama, 70, 65, 90, 125, 105),
                    new Pokemon("Tropius", PokemonType.Grama, 68, 83, 51, 72, 87),
                    new Pokemon("Jolteon", PokemonType.Eletrico, 65, 60, 130, 110, 95),
                    new Pokemon("Electabuzz", PokemonType.Eletrico, 83, 57, 105, 95, 85),
                    new Pokemon("Ampharos", PokemonType.Eletrico, 75, 85, 55, 115, 90),
                    new Pokemon("Manectric", PokemonType.Eletrico, 75, 60, 105, 105, 60),
                    new Pokemon("Donphan", PokemonType.Rocha, 120, 120, 50, 60, 60),
                    new Pokemon("Hippowdon", PokemonType.Rocha, 112, 118, 47, 68, 72),
                    new Pokemon("Flygon", PokemonType.Rocha, 100, 80, 100, 80, 80),
                    new Pokemon("Nidoking", PokemonType.Rocha, 102, 77, 85, 85, 75),
                };
            }
    }
}