using LudoGameEngine;
using System;

namespace LudoConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ludo");
            var ludoGame = new LudoGame(new Diece());
            AddPlayers(ludoGame);
            var gameIsStarted = ludoGame.StartGame();
            if (!gameIsStarted)
            {
                Console.WriteLine("Game NOT started");
                Console.Write("Press any key to exit!");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
            Console.WriteLine("Game started");

            Console.Write("Press any key to exit!");
            Console.ReadKey();
        }

        static void AddPlayers(LudoGame ludoGame)
        {
            Player latestPlayer = null;
            do
            {
                Console.WriteLine("Choose color:");
                Console.WriteLine("1. Red");
                Console.WriteLine("2. Green");
                Console.WriteLine("3. Blue");
                Console.WriteLine("4. Yellow");
                Console.Write("Enter number (press enter to skip) :");
                var color = Console.ReadLine();
                if (string.IsNullOrEmpty(color))
                {
                    return;
                }
                int.TryParse(color, out int colorNumber);

                Console.Write("Enter playername :");
                var playername = Console.ReadLine();

                latestPlayer = ludoGame.AddPlayer(playername, (PlayerColor)colorNumber);
                if (latestPlayer == null)
                {
                    Console.WriteLine("Unable to add player");
                }
            } while (latestPlayer != null);
        }
    }
}
