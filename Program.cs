using System;
using supertrumfo.dominio;

using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Game game = new Game();

        while (true)
        {
            Console.Clear();

            Console.WriteLine("1) Novo Jogo");
            Console.WriteLine("2) Configurações");
            Console.WriteLine("3) Sair");

            string? input = Console.ReadLine(); //V

            switch (input)
            {
                case "1":
                    game.startGame();
                    break;

                case "2":
                    game.configure();
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Opção invalida ");
                    break;
            }

            Console.WriteLine("Pressione enter buddy");
            Console.ReadLine();
        }
    }
}