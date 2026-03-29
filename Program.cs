using System;
using supertrumfo.dominio;

public class Program
{
    private static Random rng = new Random();
    static void Main()
    {
        //CONTADOR
        int counter = 0;
        int rounds = 3;
        //escolhas
        int[] choices = new int[2];
        Pokemon userCard, botCard; //numero 
        //Pontos
        int[] points = new int[2];

        //Pokemons
        Pokemon pikachu = new Pokemon("Pikachu", PokemonType.Eletrico, 55, 40, 90, 50, 50);
        Pokemon greninja = new Pokemon("Greninja", PokemonType.Agua, 95, 67, 122, 103, 71);
        Pokemon swampert = new Pokemon("Swampert", PokemonType.Agua, 110, 90, 60, 85, 90);
        Pokemon talonflame = new Pokemon("Talonflame", PokemonType.Fogo, 81, 71, 126, 74, 69);
        Pokemon charizard = new Pokemon("Charizard", PokemonType.Fogo, 84, 78, 100, 109, 85);
        Pokemon torterra = new Pokemon("Torterra", PokemonType.Grama, 109, 105, 56, 75, 85);
        Pokemon sceptile = new Pokemon("Sceptile", PokemonType.Grama, 85, 65, 120, 105, 85);
        Pokemon magnemite = new Pokemon("Magnemite", PokemonType.Eletrico, 35, 70, 45, 95, 55);
        Pokemon luxray = new Pokemon("Luxray", PokemonType.Eletrico, 120, 79, 70, 95, 79);
        Pokemon garchomp = new Pokemon("Garchomp", PokemonType.Rocha, 130, 95, 102, 80, 85);
        Pokemon krookodile = new Pokemon("Krookodile", PokemonType.Rocha, 117, 80, 92, 65, 70);
        //Cartas
        Pokemon[] cards =
        {
            pikachu,
            greninja,
            swampert,
            talonflame,
            charizard,
            torterra,
            sceptile,
            magnemite,
            luxray,
            garchomp,
            krookodile
        };

        //Na terceira rodada vai finalizar o jogo
        while(counter <= rounds)
        {
            startGame();
            counter++;
        }
        finishGame();
        //RODADAS
        void startGame()
        {


            //INICIO
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("Ta na hora do duelo ");
            randomCard(); //vai randomizar as escolhas

            //MOSTRAR AS OPÇOES
            userCard = cards[choices[0]]; //usuario vai receber uma carta
            botCard =  cards[choices[1]];
            showOptions(userCard, botCard);

            //PEGANDO O INPUT DO USUARIO
            string? choiceStats = Console.ReadLine();
            if(choiceStats != null && int.TryParse(choiceStats, out int numOfChoiceStats) && numOfChoiceStats >= 1 && numOfChoiceStats <= 5)
            {
                StatsPokemon chosenStat = (StatsPokemon)numOfChoiceStats;
                string winner = compareCards(chosenStat);

                Console.WriteLine($"O resultado dessa rodada é {winner} \n");  
            }
            else
            {
                Console.WriteLine("Entrada invalida, Por favor, digite um numero valido namoral \n\n");
            }
        }

        //Randomize
        void randomCard()
        {
            choices[0] = rng.Next(0, cards.Length);
            choices[1] = rng.Next(0, cards.Length);
        }
        void showOptions(Pokemon userCard, Pokemon botCard)
        {
            Console.WriteLine($"Sua carta é {userCard.pokemonName} escolha um atributo para comparar com {botCard.pokemonName} \n");
            Console.WriteLine($"{userCard}");

            Console.WriteLine("...........................................................................................................");
            Console.WriteLine("Escolha um atributo: ");
            Console.WriteLine("1 - Ataque ");
            Console.WriteLine("2 - Defesa ");
            Console.WriteLine("3 - Velocidade ");
            Console.WriteLine("4 - Ataque Especial ");
            Console.WriteLine("5 - Defesa Especial ");
        }
        string compareCards(StatsPokemon stat)
        {
            //verificar o tipo para aplicar o buff ou debuff
            int userValue = userCard.GetStat(stat);
            int botValue = botCard.GetStat(stat);
            string winner;

            Console.WriteLine("...........................................................................................................");
            Console.WriteLine("Comparando as cartas... se prepara ein \n");
            Console.WriteLine($"O atributo da sua carta é {userValue} ");
            Console.WriteLine($"O atributo da carta da maquina é {botValue} \n");

            if(userValue > botValue)
            {
                points[0]++;

                winner = "que voce é o vencedor! parabens lil bro.";
            }
            else if(userValue < botValue)
            {
                points[1]++;

                winner = "que voce perdeu, skill issue total.";
            }
            else
            {
                winner = "empate.";
            }       

            return winner;
        }
        void finishGame(){
            Console.WriteLine($"O jogo acabou... Usuario: {points[0]} X Maquina: {points[1]}");
            return;
        }

        startGame();
    }
}