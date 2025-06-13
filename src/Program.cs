using System;
using System.Runtime.CompilerServices;

namespace hrTheGathering {
    class Program
    {
        //--------------Game options-----------------
        public const int HANDSIZE = 7;
        public const int DECKSIZE = 60;
        public const int AMOUNTOFPLAYERS = 2;
        public const int STARTINGHEALTH = 10;

        //--------------Global Variables-------------
        public static bool IsGameRunning = true;


        public static void Main(string[] args)
        {
            PrintWelcome();
            InitAndRunGame();

            Console.WriteLine("The game is finished!");
            PrintWelcome();
        }

        public static void PrintWelcome()
        {
        Console.WriteLine("  **     **  ");
        Console.WriteLine(" ****   **** ");
        Console.WriteLine(" ****** *****");
        Console.WriteLine("  ********** ");
        Console.WriteLine("   *******   ");
        Console.WriteLine("    *****    ");
        Console.WriteLine("     ***     ");
        Console.WriteLine("      *      ");
        Console.WriteLine();
        Console.WriteLine("Made by Hannah Lindrob 0989357");
        }

        public static void InitAndRunGame()
        {
            GameOptions gameOptions = GameOptions.FromMode(GameModeEnum.Standard);
            Game game = new Game(gameOptions);
            game.InitPlayers();
            RunGame(game);
        }

        public static void RunGame(Game game)
        {

            while (IsGameRunning)
            {
                game.RunTick();

                // The game is over if this is true
                if (game.CheckWinCondition())
                {
                    break;
                }
            }
        }
    }
}