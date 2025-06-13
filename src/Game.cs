using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace hrTheGathering
{
    public class Game
    {
        public List<Player> Players { get; set; } = new List<Player>();
        private int CurrentPlayerIndex { get; set; }
        public GameOptions GameOptions { get; set; }
        public Player CurrentPlayer { get; set; }
        public Player Winner { get; set; }
        public bool IsGameWon { get; set; }

        public Game(GameOptions gameOptions)
        {
            GameOptions = gameOptions;

            for (int i = 0; i < gameOptions.AmountOfplayers; i++)
            {
                // The playername is extremely cursed and only used for console output
                Players.Add(new Player(gameOptions.HealtPoints, $"Player: {i + 1}"));
            } 

        }

        public void InitPlayers()
        {
            DecideStartingPlayer();

            // TODO: Fix Deckbuilder
            //DeckBuilder deckBuilder = new DeckBuilder();

            foreach (Player player in Players)
            {
                //TODO: Fix this (Or check if it's needed)
                //player.BuildDeck(deckBuilder);
                //player.DrawHand(deck);
            } 
            
        }

        private void DecideStartingPlayer()
        {
            var rand = new Random();
            CurrentPlayerIndex = rand.Next(0, GameOptions.AmountOfplayers);
            CurrentPlayer = Players[CurrentPlayerIndex];
            
        }

        private void NextPlayer()
        {
            CurrentPlayerIndex = (CurrentPlayerIndex + 1) % GameOptions.AmountOfplayers;
            CurrentPlayer = Players[CurrentPlayerIndex];
        }

        private void CheckWinCondition()
        {
            Random rand = new Random();
            if (rand.Next(0, 10) >= 8)
            {
                Winner = CurrentPlayer;
                IsGameWon = true;
            }
        }

        public void RunTick()
        {
            // Using random numbers to simulate players taking actions
            Random rand = new Random();
            Console.WriteLine($"It's {CurrentPlayer.PlayerName} turn");
            Thread.Sleep(100);
            Console.WriteLine($"{CurrentPlayer.PlayerName} played their cards");
            Thread.Sleep(100);
            Console.WriteLine($"{CurrentPlayer.PlayerName} Has ended their turn.");
            Thread.Sleep(500);

            // Begin Phase
            CurrentPlayer.Untap();
            // Draw Phase
            if (rand.Next(0, 10) >= 4 && CurrentPlayer.Hand.Count <= 7)
            {
            CurrentPlayer.DrawCard();
            }
            // Main Phase

            // Combat Phase

            // End Phase

            // End Turn

            CheckWinCondition();
            NextPlayer();
        }

        
    }
    
}