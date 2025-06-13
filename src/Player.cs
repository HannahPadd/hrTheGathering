using System;
namespace hrTheGathering
{
    public class Player
    {
        public int Health { get; set; }
        public string PlayerName { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();
        public List<Card> OnField { get; set; } = new List<Card>();
        public List<Card> DiscardPile { get; set; } = new List<Card>();
        public List<Card> DrawPile { get; set; } = new List<Card>();

        public Player(int health, string playerName)
        {
            Health = health;
            PlayerName = playerName;
        }

        public void BuildDeck(DeckBuilder deckBuilder)
        {
            DrawPile = deckBuilder.Build();
        }

        public void DrawHand(int handSize)
        {
            for (int i = 0; i < handSize; i++) {
                if (DrawPile.Count == 0) break;
                DrawCard();
            }
        }

        public void PlayCard(Card card)
        {
            if (!Hand.Contains(card))
            {
                throw new InvalidOperationException("Card not in hand!");
            }

            Hand.Remove(card);
            OnField.Add(card);
        }

        public void DiscardCard(Card card)
        {
            if (!Hand.Contains(card))
                throw new InvalidOperationException("Card not in hand!");

            Hand.Remove(card);
            DiscardPile.Add(card);
        }

        public void DrawCard()
        {
            if (DrawPile.Count > 0)
            {
                var card = DrawPile[DrawPile.Count - 1];
                DrawPile.RemoveAt(DrawPile.Count - 1);
                Hand.Add(card);
            }
            else
            {
                // TODO: Make the game know the player has and empty library and make them lose
            }
        }

        public void Untap()
        {
            
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void DeclrareBlockers()
        {
            throw new NotImplementedException();
        }

        public void Block()
        {
            throw new NotImplementedException();
        }
    }
}