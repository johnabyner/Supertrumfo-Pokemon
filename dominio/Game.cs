using System.Linq;

namespace supertrumfo.dominio
{
    public class Game
    {
        public List<Pokemon> playerDeck = new();
        public List<Pokemon> botDeck = new();
        public Deck deck = new();

        public string playerName = "Jogador";
        public int totalCards = 5;

        public Random rng = new Random();

        public bool vezDoJogador = true;

        public void configure()
        {
            Console.Write("Nome do jogador: ");
            playerName = Console.ReadLine() ?? "Jogador";

            Console.WriteLine("Quantidade de cartas: ");
            if(int.TryParse(Console.ReadLine(), out int q))
            {
                int max = deck.getAllCards().Count / 2;

                if (q > max)
                {
                    Console.WriteLine($"Maximo permitido e {max}. ajustado automaticamente bb");
                    totalCards = max;
                }
                else
                {
                    totalCards = q;
                }
            }
        }

        public void startGame()
        {
            playerDeck.Clear();
            botDeck.Clear();
            vezDoJogador = true;
        
            setupDecks();

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("Ta na hora do duelo ");

            while (playerDeck.Count > 0 && botDeck.Count > 0)
            {
                playRound();
            }

            Console.WriteLine(playerDeck.Count > 0 
                ? $"O resultado é que {playerName} venceu!!!!" 
                : "A maquina venceu, vixi! ");
        }

        public void setupDecks()
        {
            var allCards = deck.getAllCards();

            allCards = allCards.OrderBy(x => rng.Next()).ToList(); //V

            playerDeck = allCards.Take(totalCards).ToList(); //V
            botDeck = allCards.Skip(totalCards).Take(totalCards).ToList(); //V
        }

        void showOptions(Pokemon playerCard)
        {
            Console.WriteLine($"Sua carta é {playerCard}\n");

            Console.WriteLine("...........................................................................................................");
            Console.WriteLine("Escolha um atributo: ");
            Console.WriteLine("1 - Ataque ");
            Console.WriteLine("2 - Defesa ");
            Console.WriteLine("3 - Velocidade ");
            Console.WriteLine("4 - Ataque Especial ");
            Console.WriteLine("5 - Defesa Especial ");
        }
        public void playRound()
        {
            var playerCard = playerDeck[0];
            var botCard = botDeck[0];
            int choice;

            if(vezDoJogador){
                showOptions(playerCard);
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Opção inválida! Digite um número de 1 a 5:");
                }
            }
            else
            {
                Console.WriteLine($"Sua carta é {playerCard}\n");
                Console.WriteLine("Turno da Máquina OH MY GOOD! Ela está escolhendo o atributo...\n");
                choice = rng.Next(1, 6);             
            }

            StatsPokemon stat = (StatsPokemon)choice;

            int playerValue = playerCard.GetStat(stat);
            int botValue = botCard.GetStat(stat);

            Console.WriteLine("...........................................................................................................");
            Console.WriteLine("Comparando as cartas... se prepara ein \n");
            Console.WriteLine($"O atributo da sua carta é {playerValue} ");
            Console.WriteLine($"O atributo da carta da maquina é {botValue} \n");

            if(playerValue > botValue)
            {
                Console.WriteLine("Voce é o vencedor! parabens lil bro.");
                
                playerDeck.Add(botCard);

                playerDeck.RemoveAt(0);
                botDeck.RemoveAt(0);         

                vezDoJogador = true;  
            }
            else if(playerValue < botValue)
            {
                Console.WriteLine("Voce perdeu, skill issue total.");

                botDeck.Add(playerCard);
                
                botDeck.RemoveAt(0);
                playerDeck.RemoveAt(0);

                vezDoJogador = false;
            }
            else
            {
                Console.WriteLine("Empate! Cada um mantém sua carta no final do baralho.");

                playerDeck.Add(playerCard);
                botDeck.Add(botCard);

                playerDeck.RemoveAt(0);
                botDeck.RemoveAt(0);
            }       
        }

    }
}