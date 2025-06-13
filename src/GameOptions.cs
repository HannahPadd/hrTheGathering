namespace hrTheGathering
{
    public class GameOptions
    {
        public int HealtPoints { get; set; }
        public int HandSize { get; set; }
        public int DeckSize { get; set; }
        public int AmountOfplayers { get; set; }
        public GameModeEnum GameMode { get; set; }

        public GameOptions(int healthPoints, int handSize, int deckSize, int amountOfplayers, GameModeEnum gameMode)
        {
            HealtPoints = healthPoints;
            HandSize = handSize;
            DeckSize = deckSize;
            AmountOfplayers = amountOfplayers;
            GameMode = gameMode;
        }
        public static GameOptions FromMode(GameModeEnum gameMode, int amountOfPlayersCommander = 4) => gameMode switch
        {
            GameModeEnum.Standard => new GameOptions(10, 7, 60, 2, GameModeEnum.Standard),
            GameModeEnum.Legacy => new GameOptions(10, 7, 60, 2, GameModeEnum.Legacy),
            GameModeEnum.Commander => new GameOptions(40, 7, 100, amountOfPlayersCommander, GameModeEnum.Commander),
            _ => throw new ArgumentOutOfRangeException(nameof(gameMode), $"No Game Mode defined for {gameMode}!")
        };
    }
}