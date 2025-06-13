
namespace hrTheGathering
{
    public class Card
    {
        public bool InHand { get; set; }
        public bool Discarder { get; set; }
        public CardColourEnum CardColour { get; set; }
        public CardTypeEnum CardType { get; set; }
        public int Damage { get; set; }
        public int Cost { get; set; }
    }
}