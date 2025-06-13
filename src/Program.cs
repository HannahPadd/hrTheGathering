using System;
using System.Runtime.CompilerServices;
using System.Threading;

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


            PrintWelcome();
        }

        public static void PrintWelcome()
        {
        // ANSI escape codes for colors
        string pink = "\u001b[38;5;218m";
        string blue = "\u001b[38;5;117m";
        string white = "\u001b[38;5;15m";
        string reset = "\u001b[0m";


        Console.WriteLine($"{blue}   ***     ***   {reset}");
        Console.WriteLine($"{blue}  *****   *****  {reset}");
        Console.WriteLine($"{pink} ******* ******* {reset}");
        Console.WriteLine($"{pink}***************{reset}");
        Console.WriteLine($"{white}***************{reset}");
        Console.WriteLine($"{white} ************* {reset}");
        Console.WriteLine($"{pink}  ***********  {reset}");
        Console.WriteLine($"{pink}   *******   {reset}");
        Console.WriteLine($"{blue}    ***    {reset}");
        Console.WriteLine($"{blue}    **    {reset}");
        Console.WriteLine("Made by Hannah Lindrob 0989357\n");
        }

        public static void InitAndRunGame()
        {
            Game game = new Game(GameOptions.FromMode(GameModeEnum.Standard));
            Game game2 = new Game(GameOptions.FromMode(GameModeEnum.Commander));
            game.InitPlayers();
            game2.InitPlayers();



            RunGame(game);
            RunGame(game2);
        }

        public static void RunGame(Game game)
        {
            Console.WriteLine($"Starting Game of {game.GameOptions.GameMode}\n");
            while (IsGameRunning)
            {
                game.RunTick();

                // The game is over if this is true
                if (game.IsGameWon)
                {
                    break;
                }
            }

            Console.WriteLine($"{game.Winner} has won the game 🥳");
            Console.WriteLine($"The game is finished\n");
        }
    }
}