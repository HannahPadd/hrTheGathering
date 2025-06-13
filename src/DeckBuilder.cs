using System.Text.Json;

namespace hrTheGathering
{
    public class DeckBuilder
    {
        public List<Card> Lands { get; set; } = new();
        public List<Card> Instants { get; set; } = new();
        public List<Card> Artefacts { get; set; } = new();
        public List<Card> Creatures { get; set; } = new();
        public List<Card> Effects { get; set; } = new();

        public DeckBuilder()
        {
            LoadCards();
        }

        public void LoadCards()
        {
            // Use the directory of the executable (program folder), not the current working directory
            string basePath = Path.Combine(AppContext.BaseDirectory, "data");
            Lands = LoadCardsFromFile(Path.Combine(basePath, "lands.json"));
            Instants = LoadCardsFromFile(Path.Combine(basePath, "instants.json"));
            Artefacts = LoadCardsFromFile(Path.Combine(basePath, "artefacts.json"));
            Creatures = LoadCardsFromFile(Path.Combine(basePath, "creatures.json"));
            Effects = LoadCardsFromFile(Path.Combine(basePath, "effects.json"));
        }

        private static List<Card> LoadCardsFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            return new List<Card>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Card>>(json) ?? new List<Card>();
        }

        public List<Card> Build()
        {
            var deck = new List<Card>();
            deck.AddRange(Lands);
            deck.AddRange(Instants);
            deck.AddRange(Artefacts);
            deck.AddRange(Creatures);
            deck.AddRange(Effects);
            return deck;
        }
    }
}