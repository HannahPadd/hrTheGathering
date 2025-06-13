using System.Text.Json;

namespace hrTheGathering
{
    public class DeckBuilder
    {
        public Card[] Lands { get; set; }
        public Card[] Instants { get; set; }
        public Card[] Artefacts { get; set; }
        public Card[] Creatures { get; set; }
        public Card[] Effects { get; set; }

        public DeckBuilder()
        {

        }

        public void LoadCards()
        {
            Lands = LoadCardsFromFile("data/lands.json");
            Instants = LoadCardsFromFile("data/instants.json");
            Artefacts = LoadCardsFromFile("data/artefacts.json");
            Creatures = LoadCardsFromFile("data/creatures.json");
            Effects = LoadCardsFromFile("data/effects.json");
        }

        private Card[] LoadCardsFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            return Array.Empty<Card>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Card[]>(json) ?? Array.Empty<Card>();
        }
    }
}